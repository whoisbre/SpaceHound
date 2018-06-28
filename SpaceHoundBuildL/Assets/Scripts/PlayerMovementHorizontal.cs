using UnityEngine;

public class PlayerMovementHorizontal : MonoBehaviour
{
    private Vector3 right = new Vector3(0.2f, 0, 0);
    private GameObject player;
    private float speed = 6.0f;
    private float axisState;

    // Use this for initialization
    void Start()
    {

        player = GameObject.Find("Cube");

    }

    // Update is called once per frame
    void Update()
    {

       

        if (Input.GetButton("Horizontal"))
        {

            player.transform.position += Input.GetAxis("Horizontal") * right;

            player.transform.rotation = Quaternion.Slerp(player.transform.rotation, Quaternion.Euler(0, 0, Input.GetAxis("Horizontal") * -30), speed * Time.deltaTime);

            axisState = Input.GetAxis("Horizontal");
        }
        else
        {
            player.transform.rotation = Quaternion.Slerp(player.transform.rotation, Quaternion.AngleAxis(axisState , Vector3.back), speed * Time.deltaTime * 1.5f);
        }





    }


}
