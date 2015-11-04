using UnityEngine;
using System.Collections;

public class CameraShake : MonoBehaviour {

	
	
	// Transform of the camera to shake. Grabs the gameObject's transform
	// if null.
	public Transform camTransform;
	
	// How long the object should shake for.
	public float shake = 0.3f;
	// Amplitude of the shake. A larger value shakes the camera harder.
	public float shakeAmount = 0.4f;
	public float decreaseFactor = 1.0f;
	
	Vector3 originalPos;
	
	//THINGS THAT JUST WORK ! DON'T ASK WHY !
	
	void Awake(){
		if (camTransform == null)
		{ 
			camTransform = GetComponent(typeof(Transform)) as Transform;
		}
	}
	
	void OnEnable()
	{
		originalPos = camTransform.position;
	}
	
	void Update(){

		if (shake > 0)
		{
			if(BallMovement.IsDead){
				camTransform.position = originalPos + Random.insideUnitSphere * shakeAmount;
				shake -= Time.deltaTime * decreaseFactor;
			}
		}
		else
		{
			shake = 0f;
			camTransform.localPosition = originalPos;
		}
	}
}
