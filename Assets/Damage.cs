using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

    public float damageAmount = 10;
    public GameObject explosionPrefab;

    void OnTriggerEnter2D(Collider2D col)
    {
        col.gameObject.GetComponent<Health>().ChangeHealth(-damageAmount);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        col.gameObject.GetComponent<Health>().ChangeHealth(-damageAmount);
        if (explosionPrefab)
        {
            Instantiate(explosionPrefab, col.GetContact(0).point, transform.rotation);
        }
        //Add destroy game object
    }

    
}
