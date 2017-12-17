using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBrickScript : MonoBehaviour {

	public float moveSpeed = 5.0f;

	private float minimumBoundary = -2.0f;
	private float maximumBoundary = 2.0f;

	private Vector3 vector3;

	// Use this for initialization
	void Start () {
		vector3 = new Vector3 (0, -4, 0);
	}
	
	// Update is called once per frame
	void Update () {

		float position = transform.position.x + Input.GetAxis ("Horizontal") * moveSpeed;

		vector3 = new Vector3 (Mathf.Clamp (position, minimumBoundary, maximumBoundary), -4, 0);

		transform.position = vector3;

	}
}
