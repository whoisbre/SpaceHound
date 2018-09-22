using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 100000; i++) { }
        /*
         * GameObject Flash;
            Flash = GameObject.Find("Flash");
            //.GetComponent<Renderer>().material = LightOFF;
            //LightObjects[i].GetChild(0).GetComponent<Light>().enabled = false;
            Light lightComp = Flash.AddComponent<Light>();
            lightComp.color = Color.blue;
            Flash.transform.position = new Vector3(0, 5, 0);
            Destroy(this);
         */
 
            }
	
	// Update is called once per frame
	void Update () {
		
	}
}
