using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float Speed = 20f;
    public ParticleSystem Effect;
    Rigidbody2D Rb;

    private void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        Rb.velocity = transform.up * Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
            Instantiate(Effect, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Instantiate(Effect, transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    
        /*
         * var enemyComponent = GetComponent<EnemyHealth>();
         * if (enemyComponent != null)
         * { Destroy(gameObject);}
         * Or any else i.e lower health, etc..
         */
    }
}
