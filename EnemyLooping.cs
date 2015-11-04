using UnityEngine;
using System.Collections;

public class EnemyLooping : MonoBehaviour {

	int EnemyCount = 5;
	float offSetY;

	
	void Start (){

		GameObject[] Enemies = GameObject.FindGameObjectsWithTag("EnemyWarp");
		
		foreach(GameObject Enemy in Enemies) {

			//float offSetYStart = Random.Range(0.8f,3.7f);

			Vector3 pos = Enemy.transform.position;	
			pos.y += EnemyCount;
			Enemy.transform.position = pos;
			
		}

	}

	void OnTriggerEnter2D(Collider2D collider){

		//offSetY = Random.Range(0.5f,1.6f);

		if(collider.CompareTag("EnemyWarp")){

			ObsticleSelection.ObsticleCount++;

			float HeightOfObject = ((BoxCollider2D)collider).size.y;
			
			Vector3 pos = collider.transform.position;

			pos.y += HeightOfObject * EnemyCount;
			
			collider.transform.position = pos;

			if(ObsticleSelection.ObsticleCount == 5){
				ObsticleSelection.ObsticleCount = 0;
				}
		

		}


	}


}