using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMovement : MonoBehaviour
{

    private Rigidbody planetrig;

	// Use this for initialization
	void Start ()
	{
	    planetrig = GetComponent<Rigidbody>();
	    planetrig.AddForce(new Vector3(0, -10, -10), ForceMode.VelocityChange);
    }
	
}
