using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMover : MonoBehaviour
{
    public float speed = -3f;
    public float damage = 1f;

    Rigidbody2D rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(0, speed);

    }

    void Update()
    {
        transform.Rotate(0, 0, 3f);
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