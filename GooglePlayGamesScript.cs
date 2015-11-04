using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;
using GooglePlayGames.BasicApi;

public class GooglePlayGamesScript : MonoBehaviour {

	void Awake () {
	
		PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();

		PlayGamesPlatform.InitializeInstance(config);

		GooglePlayGames.PlayGamesPlatform.Activate();

	}
	
	void Start () {

		Social.localUser.Authenticate(
			(bool success) => {
		});

	}
}
