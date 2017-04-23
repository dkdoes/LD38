using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class maxSpeedRope : MonoBehaviour {
    public float maxSpeed = 20f;
    private Rigidbody rigidbody;
    public float speed;
    
	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void FixedUpdate()
    {
        
        if(rigidbody.velocity.magnitude > maxSpeed){
           rigidbody.velocity = rigidbody.velocity.normalized * maxSpeed;
        }
        speed = rigidbody.velocity.magnitude;
        Debug.Log(rigidbody.velocity);
        
    }
    
}
