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
        if (col.gameObject.name == "Asteroid_Brown5(Clone)" || col.gameObject.name == "AsteroidElectric_Green3(Clone)" || col.gameObject.name == "AsteroidLava_Violet3(Clone)" || col.gameObject.name == "AsteroidLava_Red3(Clone)" || col.gameObject.name == "AsteroidRocky_Blue4(Clone)")
        {
 

            Instantiate(explosionpref, col.gameObject.transform.position, Quaternion.Euler(0, 0, 0));
            Destroy(col.gameObject);

            HealthBar.health = HealthBar.health - 25f;
            

        }


            
        
    }
}


// Author: Lukas Heitkamp