using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Rigidbody2D>().AddForce(Random.insideUnitCircle * 150);
        gameObject.GetComponent<Rigidbody2D>().AddTorque(Random.Range(-15, 15));
	}
	
	void Update()
    {
        if (GetComponent<Health>().IsDead())
        {
            Destroy(gameObject);
        }
    }
}
