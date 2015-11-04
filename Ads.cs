using UnityEngine;
using System.Collections;
using GoogleMobileAds;

public class Ads : MonoBehaviour {

	private AdMobPlugin admob;
	private const string Interstitial_ID = "ca-app-pub-4847787002677683/5396226251";
	private const string Banner_ID = "ca-app-pub-4847787002677683/3919493058";
	public static int adCount = 0;


	// Use this for initialization
	void Awake () {
		admob = GetComponent<AdMobPlugin>();
		admob.CreateBanner(Banner_ID,AdMobPlugin.AdSize.SMART_BANNER, true, Interstitial_ID);
		admob.RequestInterstitial();
		admob.RequestAd();
	}
	
	// Update is called once per frame
	void Update () {
		HandleInterstitialLoaded();
	}
	void OnEnable(){
		AdMobPlugin.InterstitialLoaded += HandleInterstitialLoaded;
	}

	void OnDisable() {

		AdMobPlugin.InterstitialLoaded -= HandleInterstitialLoaded;

	}

	public void HandleInterstitialLoaded() {
		if(BallMovement.IsDead){
         //admob.ShowInterstitial();
		}
	}
}
