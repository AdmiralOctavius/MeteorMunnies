using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTime : MonoBehaviour {

    public float lifetime = 2;
	// Use this for initialization
	void Start () {
        Invoke("KillObect", lifetime);
	}
	
    void KillObject()
    {
        Destroy(gameObject);
    }
}
