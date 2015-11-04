using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public Text ScoreText;

	public static int Score = 0;
	public static int HighScore = 0;
	public static int MusicInt = 0;

	// Use this for initialization

	void Start () {

		Score = 0;
		HighScore = 0;
		ScoreText = GetComponent<Text>();
		
		HighScore = PlayerPrefs.GetInt("HIghScore", 0);
		MusicInt = PlayerPrefs.GetInt("MusicInt", 0);
		
	}
	
	static public void AddPoint(){

		Score++;

	}

	// Update is called once per frame
	void Update(){

	if(Score >= HighScore){
			HighScore = Score;
		}

		ScoreText.text = "" + Score;
	
		if(BallMovement.IsDead){

			ScoreText.text = "";

		}
		
	}

	void OnDestroy(){
		PlayerPrefs.SetInt("HIghScore", HighScore);
		PlayerPrefs.SetInt("MusicInt", MusicInt);
		
	}


}
