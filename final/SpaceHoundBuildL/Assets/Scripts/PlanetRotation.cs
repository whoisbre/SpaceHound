using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour {

    Rigidbody rb;
    public float torque = 5000f;

	// Use this for initialization
	void Awake ()
	{
	    rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
	    rb.AddTorque(Vector3.up * torque);
	}
}
