using UnityEngine;
using System.Collections;
using GooglePlayGames;

public class ScorePoint : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D collider){

		if(collider.tag == "Ball"){
		ScoreScript.AddPoint();
		}
	}

	void Start(){

		if(Social.localUser.authenticated){

			Social.ReportScore(ScoreScript.HighScore,"ID", (bool success) => {
			});

			if(ScoreScript.HighScore > 10) {
				Social.ReportProgress("ID", 100.0f, (bool success) => {
				});
			}
			
			if(ScoreScript.HighScore > 30) {
				Social.ReportProgress("ID", 100.0f, (bool success) => {
				});
			}
			
			if(ScoreScript.HighScore > 50) {
				Social.ReportProgress("ID", 100.0f, (bool success) => {
				});
			}
			
			if(ScoreScript.HighScore > 100) {
				Social.ReportProgress("ID", 100.0f, (bool success) => {
				});
			}
			
			if(ScoreScript.HighScore > 200) {
				Social.ReportProgress("ID", 100.0f, (bool success) => {
				});
			}
			



		}
	}

}
