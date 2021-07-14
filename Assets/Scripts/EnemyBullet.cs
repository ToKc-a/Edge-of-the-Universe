using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = -10f;
    public float damage = 1f;
    public AudioClip BulletSound;

    void Start()
    {
        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(0f, speed);
        AudioSource.PlayClipAtPoint(BulletSound, transform.position);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            //Выполнение функции TakeDamage на другом объекте
            other.gameObject.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
            Destroy(gameObject); //Уничтожение снаряда
        }
    }
}
