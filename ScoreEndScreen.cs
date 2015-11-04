using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreEndScreen : MonoBehaviour {

	Text EndScreenText;

	// Use this for initialization
	void Start () {
		EndScreenText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	
		EndScreenText.text = "" + ScoreScript.Score;

	}
}
