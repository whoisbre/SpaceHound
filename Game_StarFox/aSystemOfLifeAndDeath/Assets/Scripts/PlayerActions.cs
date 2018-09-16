// // Player ACTIONS // //

using UnityEngine;

public class PlayerActions : MonoBehaviour {
   
    // du hast 3 lebenspunkte
    public float health = 1f;

    // du kannst leiden
    public void removeHealth(float amount)
    {
        float aua2 = amount;
        health -= aua2;

        //debug Debug.Log(" 1x aua");

        if (health <= 0)
        { die(); }
    }

    // wenn du BERUEHRT wirst, leide

    // du kannst sterben
    void die()
    { Destroy(gameObject, 3); }  // wenn du tot bist destroy dich nach 3 sec 


    // biete an dich runterfallen zu lassen
    public void dropPlayerdown()
    {

    }

    // ?
    private void OnTriggerEnter(Collider other)
    {
        // destroy bullet on impact
        // if (other == Planet) { }
        if (other.gameObject.name == "Planet") { Debug.Log("bullet trifft planet"); }

        // Planet colliding will drop down
        // GetComponent<PlayerActions>().removeHealth(1f);

        // wenn player health 0 ist, dann lass den player runterfallen
        // if (PlayerActions.health == 0) { other.attachedRigidbody.useGravity = true; }

        // wenn planet mit player zusammenstoesst, drop planet
        other.attachedRigidbody.useGravity = true;


        Debug.Log(gameObject.name + " is triggered by " + other.gameObject.name);

        // GetComponent<suffer>().removeHealth(1f);
    }


    /*
     *  //// Testing ///
     */

    public void Start()
    {
        //test();
    }
    // schau ob du sterben kannst
    public void test()
    {
        for (int i = 0; i % 10000 == 0; i++)
        {
            removeHealth(1f);
        }
    }

    // schau ob du runterfallen kannst
    public void test2()
    {
        for (int i = 0; i % 10000 == 0; i++)
        {
            removeHealth(1f);
        }
    }


    /*

    * 
    * 
    * 
    * sage jemand anders er solle runterfallen
    * 
    * 
    * 
   */

}
