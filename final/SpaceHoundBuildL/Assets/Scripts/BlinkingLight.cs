using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
 

public class BlinkingLight : MonoBehaviour {

    public Material LightON;
    public Material LightOFF;

    public float offsetTime = 1;
    public List <Transform> LightObjects;


    // Use this for initialization
    void Start () {
        LightObjects = new List<Transform>();
        foreach(Transform child in transform)
        {
            LightObjects.Add(child);
        }
        LightObjects.OrderBy(wp => wp.name); // sort List

        StartCoroutine( Blink());
	}

	IEnumerator Blink()
    {  
        while (true){
            for (int i = 0; i < LightObjects.Count; i++) {
                LightObjects[i].GetComponent<Renderer>().material = LightON;
                LightObjects[i].GetChild(0).GetComponent<Light>().enabled = true;
                yield return new WaitForSeconds(offsetTime);
                LightObjects[i].GetComponent<Renderer>().material = LightOFF;
                LightObjects[i].GetChild(0).GetComponent<Light>().enabled = false;
            }
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
