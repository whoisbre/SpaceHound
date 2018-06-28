using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleMove : MonoBehaviour
{

    private GameObject player;
    private float upmax = 50.0f;
    private float downmax = -5.0f;
    private float current = -5.0f;
    private Vector3 up = new Vector3(0, 0.001f, 0);

    // Use this for initialization
    void Start () {
		player = GameObject.Find("Cube");
	}
	
	// Update is called once per frame
	void Update ()
	{
	    if (current < upmax)
	    {
	        current += 1f;
	        player.transform.position += up;
            Debug.Log(current);
	    }
	    else
	    {
	        player.transform.position = Vector3.Lerp(player.transform.position, player.transform.position - new Vector3(0, 15f, 0), 0.01f * Time.deltaTime);
	        current = -5f;
	    }


        
	}
}
