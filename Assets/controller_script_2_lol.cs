﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller_script_2_lol : MonoBehaviour {
    private float hasFired = 0f;
    public GameObject bullet;
	public Camera camera;
	public Vector3 direction0;
	public Vector3 direction1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        hasFired -= Time.deltaTime;
		if(Input.GetButton("Jump")){
            if(hasFired<=0){
                Debug.Log("shoot");
                var b = Instantiate(bullet);
				b.GetComponent<Rigidbody> ().velocity = direction0;
                b.transform.position = transform.position;
				//b.transform.rotation = camera.transform.rotation;
                hasFired = 0.7f;
            }
        }
	}
}
