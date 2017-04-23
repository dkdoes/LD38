using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class maxSpeedRope : MonoBehaviour {
    public float maxSpeed = 20f;
    public float maxAngularSpeed = 5f;
    private Rigidbody rigidbody;
    public float speed;
    public float angularspeed;
    
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
        if(rigidbody.angularVelocity.magnitude > maxAngularSpeed){
            rigidbody.angularVelocity = rigidbody.angularVelocity.normalized * maxAngularSpeed;
        }
        speed = rigidbody.velocity.magnitude;
        angularspeed = rigidbody.angularVelocity.magnitude;
        Debug.Log(rigidbody.velocity);
        
    }
    
}
