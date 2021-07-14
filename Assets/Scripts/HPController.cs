using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPController : MonoBehaviour
{
    public int hp;

    GameManager gameManager;

    public AudioClip ExplosionsSound;

    public GameObject Explosion;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    //Уничтожение объекта и добавление счета, если HP меньше или равно 0
    public void MakeDamage (int damage)
    {
        hp = hp - damage;

        if(hp<=0)
        {
            AudioSource.PlayClipAtPoint(ExplosionsSound, transform.position);
            Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
            gameManager.AddScore();
        }
    }
}
