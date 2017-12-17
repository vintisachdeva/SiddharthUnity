using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {

	public SceneManagerScript sceneManager;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D collision2D){
		
	}

	void OnTriggerEnter2D(Collider2D collision){
		sceneManager.LoadScreen ("Game Over");
	}
}