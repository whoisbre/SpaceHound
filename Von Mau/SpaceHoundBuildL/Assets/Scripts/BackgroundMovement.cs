using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour {

    public float distance = 2f;

	// Update is called once per frame
	void Update () {

        MeshRenderer meshr = GetComponent<MeshRenderer>();

        Material material = meshr.material;

        Vector2 offset = material.mainTextureOffset;

        offset.x = transform.position.x;

        offset.x = transform.position.x / transform.localScale.x / distance;

        offset.y = transform.position.y / transform.localScale.y / distance;

        material.mainTextureOffset = offset;

	}
}
