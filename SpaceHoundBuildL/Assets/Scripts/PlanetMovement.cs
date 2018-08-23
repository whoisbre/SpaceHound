using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMovement : MonoBehaviour
{

    private Rigidbody planetrig;

	// Use this for initialization
	void Start ()
	{
	    
	}

    void Awake()
    {
        planetrig = GetComponent<Rigidbody>();
        planetrig.AddForce(new Vector3(0, Random.Range(-8, 4), -10), ForceMode.VelocityChange);
        Destroy(GameObject.Find("Explosion(Clone)"));
    }
	
}

// Author: Lukas Heitkamp