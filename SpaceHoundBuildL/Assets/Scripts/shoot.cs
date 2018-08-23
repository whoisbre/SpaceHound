/*  shoot bullets if spacebar, num 0 or right enter is pressed
 * 
 * Author: Fabian Kessler
 */

 /*using System.Collections;
using System.Collections.Generic;
  * 
  */

using UnityEngine;

public class shoot : MonoBehaviour {

    // spawn point of bullet
    public GameObject BulletEmitter;

    // ref prefab
    public GameObject Bullet;

    private GameObject Explosion;

    public float BulletSpeed;
    
	void Start ()
	{
        Explosion = new GameObject();
	    GameObject.Find("Explosion");
	}

    float fireRate = 255f;
    float nextTimeToFire = 0f;
    float letzterPlatzfuerSchiessen = 90f;

  //  public Camera CameraHelper;   

    void Update () {

        // shoot if "spacebar" or "numpad 0" or "numpad enter" is pressed
        if (Input.GetKey("space") && Time.time >= nextTimeToFire ||
            Input.GetKey("[0]") && Time.time >= nextTimeToFire || 
            Input.GetKey("enter") && Time.time >= nextTimeToFire) {

            // short interval till next shot
            nextTimeToFire = Time.time + (1f / fireRate);

            // create bullet
            GameObject TempBulletHandler;
            TempBulletHandler = Instantiate(Bullet,
                BulletEmitter.transform.position,
                BulletEmitter.transform.rotation)
                as GameObject;

            Rigidbody TempRigidBody;
            TempRigidBody = TempBulletHandler.GetComponent<Rigidbody>();
                
            // push bullet forward
            TempRigidBody.AddForce(transform.forward * BulletSpeed * 11); // war 222

            Destroy(TempBulletHandler, 2.0f);


            RaycastHit getroffenesObj;
            // CameraHelper = Camera.main;

            if (Physics.Raycast(BulletEmitter.transform.position,
                    BulletEmitter.transform.forward, out getroffenesObj,
                    letzterPlatzfuerSchiessen)) {


                //planet1.NimmSchaden(0.1f);
               // Planet.NimmSchaden(0.1f);
                Debug.Log(getroffenesObj.transform.name);
                Destroy(getroffenesObj.transform.gameObject);
                Instantiate(Explosion, getroffenesObj.transform);

                // Target 
                //getroffenesObj = getroffenesObj.transform.GetComponent<Target>();

            }

        }
        
    }
    void schiesse(){ }
}
                // maybe
                // TempBulletHandler.transform.Rotate(Vector3.left * 90);
    //public bool doShoot = false;
    //public int doShoot;
/*	   public int shootcnt = 0;
    int doShoot = 0;
        // shoot every second frame
        shootcnt = shootcnt++;
        if (shootcnt >= 6) { shootcnt = 0; }
        Debug.Log(shootcnt);
*/
/*  Changelog:
 *      26 Jun  Raycasting, added crosshair
 *      24 Jun  added multiple keys,
 *              you can shoot holding down space,
 *              fixed position in y axis
 *      23 Jun  rigidbody constr - freeze rotation 
 *              
 * 
 */