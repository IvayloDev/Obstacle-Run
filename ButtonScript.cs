using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using GooglePlayGames;

public class ButtonScript : MonoBehaviour {


	public GameObject musicButt;
	public Sprite MusicOnSprite;
	public Sprite MusicOffSprite;

	string subject = "Check This Game !";
	string body = "My HighScore In #SlowRun Is " + ScoreScript.HighScore + " ! Try To Beat Me. https://play.google.com/store/apps/details?id=com.IvayloDev.SlowRun";

	public Animator EndScreenAnim;

	public void OnPlayClick() {
			Application.LoadLevel("GameScreen");
	}

	public void OnMenuClick(){

		Application.LoadLevel("StartScreen");

	}

	public void OnShareClick(){

		#if UNITY_ANDROID
		//Reference of AndroidJavaClass class for intent
		AndroidJavaClass intentClass = new AndroidJavaClass ("android.content.Intent");
		//Reference of AndroidJavaObject class for intent
		AndroidJavaObject intentObject = new AndroidJavaObject ("android.content.Intent");
		//call setAction method of the Intent object created
		intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>("ACTION_SEND"));
		//set the type of sharing that is happening
		intentObject.Call<AndroidJavaObject>("setType", "text/plain");
		//add data to be passed to the other activity i.e., the data to be sent
		intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), subject);
		intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), body);
		//get the current activity
		AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
		AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>("currentActivity");
		//start the activity by sending the intent data
		currentActivity.Call ("startActivity", intentObject);
		#endif



	}

	public void OnMusicClick(){

		if(ScoreScript.MusicInt == 0){
			ScoreScript.MusicInt = 1;
		}else{
			ScoreScript.MusicInt = 0;
		}


	}

	public void OnLeaderBoardClick(){

		Social.ShowLeaderboardUI();

	}

	public void OnAchievementClick(){

		Social.ShowAchievementsUI();

	}

	public void OnRateClick(){

		Application.OpenURL("https://play.google.com/store/apps/details?id=com.IvayloDev.SlowRun");

	}

	public void OnRestartClick(){

		StartCoroutine(Restart());

	}	

	IEnumerator Restart() {

		EndScreenAnim.SetBool("EndScreenFadeOut", true);

		yield return new WaitForSeconds(0.5f);

		Application.LoadLevel(Application.loadedLevel);
	}


	void Update(){

		if(ScoreScript.MusicInt == 1){
			musicButt.GetComponent<Image>().sprite = MusicOffSprite;
			AudioListener.volume = 0;
		}else if(ScoreScript.MusicInt == 0){
			musicButt.GetComponent<Image>().sprite = MusicOnSprite;
			AudioListener.volume = 1;
		}



	}


}
