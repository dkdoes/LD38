using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {
    public GameObject follow;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate(){
        this.transform.position = follow.transform.position;
        var tempposition = this.transform.position;
        tempposition.z -= 5;
        tempposition.y = 6;
        this.transform.position = tempposition;
    }
}
