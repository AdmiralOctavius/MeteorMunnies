using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour {

    public GameObject objToSpawn;
    public Rigidbody2D projectile;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            Rigidbody2D clone;
            clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody2D;
            clone.velocity = transform.TransformDirection(Vector2.left * 10);
            //GameObject bullet = Instantiate(objToSpawn, gameObject.transform.position, Quaternion.identity);
            //bullet
        }
	}


}
