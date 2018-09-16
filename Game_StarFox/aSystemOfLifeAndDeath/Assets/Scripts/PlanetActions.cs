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

public class PlanetActions : MonoBehaviour {

// move planets
    void Update()
    {        move();    }
    void move()
    {        transform.position += transform.forward * -0.02f;    }

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

        GameObject.Find("Player").GetComponent<PlayerActions>().removeHealth(1f);

        // Planet colliding will drop down
        // GetComponent<PlayerActions>().removeHealth(1f);

        // wenn player health 0 ist, dann lass den player runterfallen
        //        GameObject.Find("Player").GetComponent<PlayerActions>().health -= 10.0f; ;
        if (GameObject.Find("Player").GetComponent<PlayerActions>().health == 0) {
        // bei zusammenstoss, drope player
            other.attachedRigidbody.useGravity = true; }
    
        //other.attachedRigidbody.useGravity = true;


        Debug.Log(gameObject.name + " is triggered by " + other.gameObject.name);

        // GetComponent<suffer>().removeHealth(1f);
    }

    public void dropPlayerdown()
    {
        // GetComponent<Collider>.attachedRigidbody.useGravity = true;
    }

    // ist der andere health == 0, lass ihn runterfallen

    // destroy bullet on impact


    /*
     *  //// Testing ///
     */

    public void Start()
    {
        //test();
        test2();
        test3();
    }
    // schau ob du sterben kannst
    public void test()
    {
        for (int i = 0; i <= 3; i++)
        { removeHealth(1f);
          Debug.Log("health: " + health); }
    }

    // schau ob du runterfallen kannst
    public void test2()
    {
        for (int i = 0; i % 10000 == 0; i++)
        {
            ; ;
        }
    }

    // schau o 
    public void test3()
    {
        for (int i = 0; i % 10000 == 0; i++)
        {
            ; ;
        }
    }

    /*     * 
     * du kannst leiden
     * 
     * wenn du getroffen wirst, leide
     * 
     * du kannst leiden
     * 
     * wenn du tot bist benutze gravitation
     * 
     * wenn du tot bist destroy dich nach 3 sec
     * 
    */
}
