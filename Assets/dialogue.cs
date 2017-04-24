using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue : MonoBehaviour {
    
    public string diaglogue;
    UnityEngine.UI.Text text;
    uitexttimer textTimer;
    bool triggered = false;


	// Use this for initialization
	void Start () {

        textTimer = text.gameObject.GetComponent<uitexttimer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    private void OnTriggerEnter(Collider other)
    {
        if (true)
        {if (triggered == false)
            {


                triggered = true;
                text.text = diaglogue;
                textTimer.active = true;
                textTimer.curTime = 0;


            }

        }
    }
}
