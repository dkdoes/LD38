﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {
    public float speed = 0.2f;
    //private float hasFired = 0f;
    //public GameObject control;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //hasFired -= Time.deltaTime;
	}
    void FixedUpdate(){
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");
        var t = transform.position;
        t.x += x * speed;
        t.z += y * speed;
        transform.position = t;
        
    }
}
