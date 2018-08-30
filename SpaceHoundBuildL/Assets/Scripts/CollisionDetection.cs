using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    private GameObject explosionpref;




    void Start()
    {
        explosionpref = GameObject.Find("Explosion");
        explosionpref.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }


    


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Planet(Clone)")
        {
 

            Instantiate(explosionpref, col.gameObject.transform.position, Quaternion.Euler(0, 0, 0));
            Destroy(col.gameObject);
            

        }


            
        
    }
}


// Author: Lukas Heitkamp