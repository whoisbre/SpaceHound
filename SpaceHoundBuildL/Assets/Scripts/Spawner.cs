using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    private float timer = 2f;
    private GameObject planet;

	// Use this for initialization
	void Start ()
	{
	    planet = GameObject.Find("PlanetOrigin");
	    planet.name = "Planet";

    }
	
	// Update is called once per frame
	void Update ()
	{

	    timer -= Time.deltaTime;
	    

        if (timer <= 0f)
	    {
	        Instantiate(planet, new Vector3(Random.Range(-9f, 9), 11, Random.Range(10, 30)),
	            Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            
	        timer = 2f;
	    }


	}


}
