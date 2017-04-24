using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour {
    //public Vector3 direction;
    public float speed = 10f;
    
	// Use this for initialization
	void Start () {
		Debug.Log ("asteroid");
		//var rigidbody = GetComponent<Rigidbody>();
        //rigidbody.velocity = direction * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate () {
		
	}
}
