using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour {

	public Text HighScoreText;

	// Use this for initialization
	void Update() {

		HighScoreText.text = "" + ScoreScript.HighScore;

		if(ScoreScript.Score >= ScoreScript.HighScore){
			ScoreScript.HighScore = ScoreScript.Score;
		}

	}

}
