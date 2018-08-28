using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour {

    public float speed = 0.02f;
    public MeshRenderer meshr;
    public Material material;

    void Start()
    {
        
        meshr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update () {


        material = meshr.material;

        float offset = Time.fixedTime * speed;
        meshr.material.mainTextureOffset = new Vector2(0, -offset);



        /*
        offset.x = transform.position.x;

        offset.x = transform.position.x / transform.localScale.x / distance;

        offset.y = transform.position.y / transform.localScale.y / distance;

        material.mainTextureOffset = offset;
        */
    }
}
