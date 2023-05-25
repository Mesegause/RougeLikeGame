using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 0.1f;
    public float health;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) 
            transform.position += new Vector3(0, speed, 0);
        
        if (Input.GetKey(KeyCode.S)) 
            transform.position += new Vector3(0, -speed, 0);
        
        if (Input.GetKey(KeyCode.D)) 
            transform.position += new Vector3(speed, 0, 0);
        
        if (Input.GetKey(KeyCode.A)) 
            transform.position += new Vector3(-speed, 0, 0);
        
        if (Input.GetAxis("Horizontal") < 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
