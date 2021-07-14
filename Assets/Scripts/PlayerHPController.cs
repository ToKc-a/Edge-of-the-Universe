using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHPController : MonoBehaviour
{
    public int maxHp = 5;
    public int hp;

    public HealthBar healthBar;

    GameManager gameManager;

    public AudioClip ExplosionsSound;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        hp = maxHp;
        healthBar.SetMaxHealth(maxHp);
    }

    //Уничтожение объекта, если HP меньше или равно 0
    public void TakeDamage(int damage)
    {
        hp = hp - damage;

        if (hp <= 0)
        {
            AudioSource.PlayClipAtPoint(ExplosionsSound, transform.position);
            Destroy(gameObject);
            gameManager.PlayerDied();
        }

        healthBar.SetHealth(hp);
    }
}
