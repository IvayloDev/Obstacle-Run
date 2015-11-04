using UnityEngine;
using System.Collections;

public class ShieldScript : MonoBehaviour {

	public static bool PickedUpShield;
	public static bool SetShield;
	

	// Use this for initialization
	void Start () {
	
		PickedUpShield = false;
		SetShield = false;

	}
	
	void OnTriggerEnter2D(Collider2D collider){

		if(collider.CompareTag("Ball")){

			PickedUpShield = true;
			SetShield = true;

		}
	}
}
