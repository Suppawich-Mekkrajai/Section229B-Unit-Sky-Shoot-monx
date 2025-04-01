using UnityEngine;
using System;
public class EnemyHealth : MonoBehaviour


{
    public float health = 100f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        rb.isKinematic = false; 
        rb.useGravity = true;
        Destroy(gameObject, 3f); 
    }
    void OnMouseDown()
    {
        FindObjectOfType<GameManager>().AddScore(10);
        Destroy(gameObject);
    }
}

