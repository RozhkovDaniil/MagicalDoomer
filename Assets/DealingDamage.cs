using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealingDamage : MonoBehaviour
{
    public float BulletSpeed = 30f;
    public Rigidbody2D phisycs;
    public int damage = 20;



    void Start ()
    {
        phisycs.velocity = transform.right * BulletSpeed;    
    }

    void OnTriggerEnter2D (Collider2D hitinfo)
    {
        Debug.Log(hitinfo.name);
        if (hitinfo.name != "Square")
        {
            Destroy(gameObject);
        }
    }
}
