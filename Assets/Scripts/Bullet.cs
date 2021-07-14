using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
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
        //Выполнение функции MakeDamage на другом объекте
        other.gameObject.SendMessage("MakeDamage", damage, SendMessageOptions.DontRequireReceiver);
        Destroy(gameObject); //Уничтожение снаряда
    }
}
