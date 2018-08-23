using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementVertical : MonoBehaviour {

    private Vector3 up = new Vector3(0, 0.2f, 0);
    private GameObject player;


    // Use this for initialization
    void Start()
    {

        player = GameObject.Find("Cube");

    }

    // Update is called once per frame
    void Update()
    {



        if (Input.GetButton("Vertical"))
        {

            player.transform.position += Input.GetAxis("Vertical") * up;

        }





    }


}

// Author: Lukas Heitkamp
