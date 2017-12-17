using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	int score = 0;

	public void updateScore(int amount)
	{
		score += amount;
		GetComponent <Text>().text = "Score: " + score;
	}

}