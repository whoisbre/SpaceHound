using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockPlanetYAxis : MonoBehaviour {
 

    void lockPlanets() {
        {
            //GameObject Planet = GameObject.Find("TestPlanet");
            Rigidbody m_Rigidbody;
            m_Rigidbody = GetComponent<Rigidbody>();
            m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionY;
        }
    }
  
	// Use this for initialization
	void Start () {    lockPlanets();}
	
	// Update is called once per frame
	void Update () {}
}

//Planet.transform.position += Planet.transform.up * 0.1f;

// freez position?// if (Planet != null) { Debug.Log("Hab planet"); } // GetComponent<TestPlanet>; // Planet.transform.position.y =+ 0;//        Planet.transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);

// Author: Fabian Kessler