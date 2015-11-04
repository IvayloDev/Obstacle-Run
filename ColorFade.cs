using UnityEngine;
using System.Collections;

public class ColorFade : MonoBehaviour {

	public Color color;
	public Color TenPointColor = new Color();
	public Color TwentyPointColor = new Color();
	public Color ThirtyPointColor = new Color();
	public Color FourtyPointColor = new Color();
	
	

	Camera cam;

	float duration = 5f; 
	float time = 0f;

	void Start() {

		cam = GetComponent<Camera>();

		//Colors!
	}

	IEnumerator cor() {
		yield return new WaitForSeconds(3f);
		time = 0;
	}

	void Update() {

		cam.backgroundColor = color;

		if(ScoreScript.Score == 10){

			color = Color.Lerp(color,TenPointColor, time);
		if(time < 1){
			time += Time.deltaTime/duration;
			StartCoroutine(cor());
			}
		}

		if(ScoreScript.Score == 20){
			
			color = Color.Lerp(color,TwentyPointColor, time);
			if(time < 1){
				time += Time.deltaTime/duration;
				StartCoroutine(cor());
			}
		}

		if(ScoreScript.Score == 30){
			
			color = Color.Lerp(color,ThirtyPointColor, time);
			if(time < 1){
				time += Time.deltaTime/duration;
				StartCoroutine(cor());
			}
		}

		if(ScoreScript.Score == 40){
			
			color = Color.Lerp(color,FourtyPointColor, time);
			if(time < 1){
				time += Time.deltaTime/duration;
				StartCoroutine(cor());
			}
		}
	}
}
