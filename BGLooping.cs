using UnityEngine;
using System.Collections;

public class BGLooping : MonoBehaviour {

	public int BGCount = 2;

	void Start (){
		
		GameObject[] BGs = GameObject.FindGameObjectsWithTag("BG");
		
		foreach(GameObject BG in BGs) {

			//float offSetYStart = Random.Range(0.8f,3.7f);
			
			Vector3 pos = BG.transform.position;	
			pos.y += BGCount;
			BG.transform.position = pos;
			
		}
		
	}

	void OnTriggerEnter2D(Collider2D collider){

		

		
		if(collider.CompareTag("BG")){
			
			float HeightOfObject = ((BoxCollider2D)collider).size.y;
			
			Vector3 pos = collider.transform.position;

			pos.y += HeightOfObject * BGCount;
			
			collider.transform.position = pos;
			
		}

	}
}
