using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {
    public GameObject follow;
    public float offsetY = 4;
    public float offsetZ = -8;
    public GameObject follow2;
    //public Vector3 t3;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate(){
        this.transform.position = follow.transform.position;
        
        var t = follow.transform.position;
        var t2 = follow2.transform.position;
        var t3 = t - t2;
        t3 /= 2;
        t3.z += offsetZ;
        t3.y += offsetY;
        t3 = t - t3;
        /*
        t3.y = 4;
        t3.z -= 4;
        this.transform.position = t3;*/
        var tempposition = this.transform.position;
        tempposition.z += offsetZ;
        tempposition.y += offsetY;
        
        //this.transform.position = tempposition;
        this.transform.position = t3;
    }
}
