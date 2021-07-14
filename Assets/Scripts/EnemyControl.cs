using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public GameObject enemyBulletPrefab;
    public float speed = -3f;
    public float reloadTime = 0.25f;
    public float damage = 2f;

    float elapsedTime = 0f;

    Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(0, speed);
    }

    void Update()
    {
        //Отсчет времени после выстрела
        elapsedTime += Time.deltaTime;

        if(elapsedTime > reloadTime)
        {
            //Создание снаряда на расстоянии -3.5 единицы перед игроком
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(0, -3.5f, 0);
            Instantiate(enemyBulletPrefab, spawnPos, Quaternion.identity);

            //Сбросить таймер стрельбы
            elapsedTime = 0f;
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Выполнение функции TakeDamage на другом объекте
            other.gameObject.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject); //Уничтожение снаряда
        }
    }
}
