using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_CollisionDet : MonoBehaviour {

 
    private GameObject explosionpref;




    void Start()
    {
        explosionpref = GameObject.Find("Explosion");
        explosionpref.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

    }



    int PlayerHealth = 5; // 3 health + 2 (gets hit by insivible cube + ship)



    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Planet(Clone)")
        {
            Instantiate(explosionpref, col.gameObject.transform.position, Quaternion.Euler(0, 0, 0));
            Destroy(col.gameObject);
        }


        // Manage Life
        PlayerHealth--;
        Debug.Log("PlayerHealth: " + PlayerHealth);
        Debug.Log(col.gameObject.name);

        if (PlayerHealth <= 0)
        {
            // Game Over
        }



    }
}
 