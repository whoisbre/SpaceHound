using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_behav : MonoBehaviour
{
    // bullet kann planeten abschießen

    // bullet stirbt on impact

    // du kannst sterben
    void die()
    { Destroy(gameObject, 0); }
    
    // destroy bullet on impact
    private void OnTriggerEnter(Collider other)
    {
      //if (other.gameObject.name == "bullet") { Debug.Log("bullet trifft planet"); } // heißt projektil so?

        die();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
// Author: Fabian Kessler