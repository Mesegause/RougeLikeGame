using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack1 : MonoBehaviour
{
    private float timeBtwAttack;
    private Player player;

    public float startTimeBtwAttack;
    public Transform shotPoint;
    public GameObject Venom;

    void Update()
    {
        if (timeBtwAttack <= 0)
        {
            Instantiate(Venom, shotPoint.position, transform.rotation);
            timeBtwAttack = startTimeBtwAttack;
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }
}
