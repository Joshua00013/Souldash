using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacking : MonoBehaviour
{
    public Transform attackPoint;
    public GameObject attackPrefab;

    public float attackForce = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Attack();
        }
    }
    
    void Attack()
    {
        GameObject projectile = Instantiate(attackPrefab, attackPoint.position, attackPoint.rotation);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.AddForce(attackPoint.up * attackForce, ForceMode2D.Impulse);
    }
}
