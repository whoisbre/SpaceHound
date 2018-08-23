using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCameraRotation : MonoBehaviour
{
    private Quaternion rotation;

	// Use this for initialization
	void Awake ()
	{
	    rotation = transform.rotation;
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
	    transform.rotation = rotation;
	}
}

// Author: Lukas Heitkamp
