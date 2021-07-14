using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipControl : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject bulletPrefab;

    public float speed = 37f;
    public float xLimit = 18f;
    public float reloadTime = 0.25f;

    float elapsedTime = 0f;


    void Start()
    {

    }

    void Update()
    {
        //Отсчет времени после выстрела
        elapsedTime += Time.deltaTime;

        //Перемещение игрока влево и вправо
        float xInput = Input.GetAxis("Horizontal");
        transform.Translate(xInput * speed * Time.deltaTime, 0f, 0f);

        //Фиксирование корабля по оси Х
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -xLimit, xLimit);
        transform.position = position;

        //Огонь клавишей "Прыжок" (по-умолчанию - пробел)
        //Срабатывает только в случае, если время перезарядки прошло
        if (Input.GetButtonDown("Jump") && elapsedTime > reloadTime)
        {
            //Создние снаряда на расстоянии 3.5 единицы перед игроком
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(0, 3.5f, 0);
            Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

            //Сбросить таймер стрельбы
            elapsedTime = 0f;
        }
    }
}