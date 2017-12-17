using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickDestroyerScript : MonoBehaviour {

	public ScoreScript scoreScript;

	void OnCollisionEnter2D(Collision2D collision2D){
		if (gameObject.tag == "Yellow")
			scoreScript.updateScore (10);
		 else if (gameObject.tag == "Blue")
			scoreScript.updateScore (20);
		
		Destroy (gameObject);
	}


}
