using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller_script_2_lol : MonoBehaviour {
    private float hasFired = 0f;
    public GameObject bullet;
	public Camera camera;
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
                b.transform.position = transform.position;
				//b.transform.rotation = camera.transform.rotation;
                var t = camera.transform.rotation.eulerAngles;
                t.y = 1;
                b.GetComponent<Rigidbody>().velocity = t;
                hasFired = 0.7f;
            }
        }
	}
}
