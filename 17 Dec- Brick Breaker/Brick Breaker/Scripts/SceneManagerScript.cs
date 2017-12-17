using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour {

	public void LoadScreen(String name){
		SceneManager.LoadScene (name);
	}
}