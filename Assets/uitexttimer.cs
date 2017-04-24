using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uitexttimer : MonoBehaviour {

    public bool active = false;
    public float curTime;
    public float endTime;
    UnityEngine.UI.Text text;
    GameObject panel;
    UnityEngine.UI.Image panelImage;

    public Color c;
    public Color deactive;
    // Use this for initialization
    void Start () {
        text = gameObject.GetComponent<UnityEngine.UI.Text>();
        panel = gameObject.transform.parent.gameObject;
        panelImage = panel.GetComponent<UnityEngine.UI.Image>();



	}
	
	// Update is called once per frame
	void Update () {

        if (active) {
            curTime += Time.deltaTime;

            panelImage.color = c;

            if (curTime > endTime) {
                curTime = 0;
                active = false;
                panelImage.color = deactive;
                text.text = "";

            }
        }
        else
        {

        }


	}
}
