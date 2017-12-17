using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BallScript : MonoBehaviour {

	public float speed  =5.0f;
	Boolean hasReleased = false;
	public BottomBrickScript bottomBrick;


	// Update is called once per frame
	void Update () {
		
		if (!hasReleased) {
			this.transform.position = new Vector2 (bottomBrick.transform.position.x, transform.position.y);
		}
			if (Input.GetKeyDown (KeyCode.Space)) {
			hasReleased = true;					
			GetComponent<Rigidbody2D> ().velocity = new Vector2(UnityEngine.Random.Range (-2.7f, 2.7f), 8f);
			}
		}
}
