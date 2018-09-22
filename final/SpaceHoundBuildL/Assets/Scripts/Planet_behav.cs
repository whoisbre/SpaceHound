// // Planet ACTIONS // //

/*
 * da
 * 
 * raumschiff stirbt wenn es von planeten getroffen wird
 * planet faellt wenn er collidiert
 * 
 */

/* fehlt
 * 
 * bullet kann planeten abschießen
 * planet destroyed wenn er collidiert
 */

using UnityEngine;

public class Planet_behav : MonoBehaviour
{
 // du hast 2 lebenspunkte
    public float health = 1f;

    // du kannst leiden
    public void removeHealth(float amount)
    {
        float aua2 = amount;
        health -= aua2;

        //debug
        Debug.Log(" 1x aua");

        if (health <= 0)
        { die(); }
    }

    // wenn du BERUEHRT wirst, leide

    // du kannst sterben
    void die()
    { Destroy(gameObject, 0); }  // wenn du tot bist destroy dich nach 3 sec 


    // biete an dich runterfallen zu lassen
    private void OnTriggerEnter(Collider other)
    {
        // destroy bullet on impact
        // if (other == Planet) { }
        if (other.gameObject.name == "bullet") { Debug.Log("bullet trifft planet"); } // heißt projektil so?

        GameObject.Find("Player").GetComponent<Player_behav>().removeHealth(1f);

        // Planet colliding will drop down
        // GetComponent<PlayerActions>().removeHealth(1f);

        // wenn player health 0 ist, dann lass den player runterfallen
        //        GameObject.Find("Player").GetComponent<PlayerActions>().health -= 10.0f; ;
        if (GameObject.Find("Player").GetComponent<Player_behav>().health == 0)
        {
            // bei zusammenstoss, drope player
            other.attachedRigidbody.useGravity = true;
        }

        //other.attachedRigidbody.useGravity = true;

        removeHealth(1f);

        Debug.Log(gameObject.name + " is triggered by " + other.gameObject.name);

        // GetComponent<suffer>().removeHealth(1f);
    }

    public void dropPlayerdown()
    {
        // GetComponent<Collider>.attachedRigidbody.useGravity = true;
    }
}

// Author: Fabian Kessler