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

			Social.ReportScore(ScoreScript.HighScore,"CgkIvLiw48EIEAIQAg", (bool success) => {
			});

			if(ScoreScript.HighScore > 10) {
				Social.ReportProgress("CgkIvLiw48EIEAIQAQ", 100.0f, (bool success) => {
				});
			}
			
			if(ScoreScript.HighScore > 30) {
				Social.ReportProgress("CgkIvLiw48EIEAIQAw", 100.0f, (bool success) => {
				});
			}
			
			if(ScoreScript.HighScore > 50) {
				Social.ReportProgress("CgkIvLiw48EIEAIQBQ", 100.0f, (bool success) => {
				});
			}
			
			if(ScoreScript.HighScore > 100) {
				Social.ReportProgress("CgkIvLiw48EIEAIQBA", 100.0f, (bool success) => {
				});
			}
			
			if(ScoreScript.HighScore > 200) {
				Social.ReportProgress("CgkIvLiw48EIEAIQBg", 100.0f, (bool success) => {
				});
			}
			



		}
	}

}
