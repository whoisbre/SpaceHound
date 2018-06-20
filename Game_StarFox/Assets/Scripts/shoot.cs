using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

    // spawn point of bullet
    public GameObject BulletEmitter;

    // ref das prefab
    public GameObject Bullet;

    public float BulletSpeed;
    
    // Use this for initialization
	void Start () {
		
	}
	
	void Update () {
        // press space to shoot
        if (Input.GetKeyDown("space")) {
            
            // create bullet
        GameObject TempBulletHandler;
            TempBulletHandler = Instantiate(Bullet,
                BulletEmitter.transform.position,
                BulletEmitter.transform.rotation)
                as GameObject;

                // maybe
                // TempBulletHandler.transform.Rotate(Vector3.left * 90);
            
            Rigidbody TempRigidBody;
            TempRigidBody = TempBulletHandler.GetComponent<Rigidbody>();

            // push bullet forward
            TempRigidBody.AddForce(transform.forward * BulletSpeed * 222);

            Destroy(TempBulletHandler, 2.0f);
        
        // failstate?
    // spaceHound
        }
	}
}
