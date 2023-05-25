using System;
using System.Collections;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float speed;
    public float lifetime;
    public float distance;
    public int damage;
    public LayerMask whatIsSolid;

    private void Awake()
    {
        IEnumerator DestroyAfterTime(float time)
        {
            yield return new WaitForSeconds(time);
            
            DestroyBubble();
        }

        StartCoroutine(DestroyAfterTime(10f));
    }

    private void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime, Space.World);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag is not "Enemy")
            return;
        
        other.gameObject.GetComponent<Enemy>().TakeDamage(damage);
        DestroyBubble();
    }

    private void DestroyBubble()
    {
        Destroy(gameObject);
    }
}