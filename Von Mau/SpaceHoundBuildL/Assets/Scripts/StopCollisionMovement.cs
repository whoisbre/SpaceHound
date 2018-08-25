using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCollisionMovement : MonoBehaviour
{

    private Rigidbody rigidbodyCube;


	// Use this for initialization
	void Start ()
	{

	    rigidbodyCube = GetComponent<Rigidbody>();

	}


    void Update()
    {
        rigidbodyCube.velocity = Vector3.zero;
    }
}
