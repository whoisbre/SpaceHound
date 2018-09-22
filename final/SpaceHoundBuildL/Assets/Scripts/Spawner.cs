using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    private float timer = 3f;
    public GameObject planet0;
    public GameObject aster1;
    public GameObject aster2;
    public GameObject aster3;
    public GameObject aster4;
    private int randomnum;


    // Use this for initialization
    void Start ()
	{


	}
	
	// Update is called once per frame
	void Update ()
	{

	    timer -= Time.deltaTime;
        randomnum = Random.Range(0, 4);

        if (timer <= 0f)
	    {
            if(randomnum == 0)
	            Instantiate(planet0, new Vector3(Random.Range(-9f, 9), 30, Random.Range(40, 70)), Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
	        else if (randomnum == 1)
                Instantiate(aster1, new Vector3(Random.Range(-9f, 9), 30, Random.Range(40, 70)), Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            else if (randomnum == 2)
                Instantiate(aster2, new Vector3(Random.Range(-9f, 9), 30, Random.Range(40, 70)), Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            else if (randomnum == 3)
                Instantiate(aster3, new Vector3(Random.Range(-9f, 9), 30, Random.Range(40, 70)), Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));
            else
                Instantiate(aster4, new Vector3(Random.Range(-9f, 9), 30, Random.Range(40, 70)), Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360)));

            timer = 3f;
	        
        }

	}


}

// Author: Lukas Heitkamp
