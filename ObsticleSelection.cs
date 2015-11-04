using UnityEngine;
using System.Collections;

public class ObsticleSelection : MonoBehaviour {

	public GameObject E1nemy1;
	public GameObject E1nemy2;	
	public GameObject E1nemy3;
	public GameObject E1nemy4;
	public GameObject E1nemy5;
	
	public GameObject E2nemy1;
	public GameObject E2nemy2;	
	public GameObject E2nemy3;
	public GameObject E2nemy4;
	public GameObject E2nemy5;

	public GameObject E3nemy1;
	public GameObject E3nemy2;	
	public GameObject E3nemy3;
	public GameObject E3nemy4;
	public GameObject E3nemy5;
	
	public GameObject E4nemy1;
	public GameObject E4nemy2;	
	public GameObject E4nemy3;
	public GameObject E4nemy4;
	public GameObject E4nemy5;

	public GameObject E5nemy1;
	public GameObject E5nemy2;	
	public GameObject E5nemy3;
	public GameObject E5nemy4;
	public GameObject E5nemy5;

	public static int RandomEnemy1;
	public static int RandomEnemy2;
	public static int RandomEnemy3;
	public static int RandomEnemy4;
	public static int RandomEnemy5;
	
	public static int ObsticleCount = 0;

	// Use this for initialization
	void Start () {
		ObsticleCount = 0;

		RandomEnemy1 = Random.Range(1,6);
		RandomEnemy2 = Random.Range(1,6);
		RandomEnemy3 = Random.Range(1,6);
		RandomEnemy4 = Random.Range(1,6);
		RandomEnemy5 = Random.Range(1,6);
		
	}

	void ObsticleRandom1(){
		RandomEnemy1 = Random.Range(1,6);
	}
	void ObsticleRandom2(){
		RandomEnemy2 = Random.Range(1,6);
	}
	void ObsticleRandom3(){
		RandomEnemy3 = Random.Range(1,6);
	}
	void ObsticleRandom4(){
		RandomEnemy4 = Random.Range(1,6);
	}
	void ObsticleRandom5(){
		RandomEnemy5 = Random.Range(1,6);
	}


	// Update is called once per frame
	void Update () {

		if(ObsticleCount == 1){
			ObsticleRandom1();
		}
		
		if(ObsticleCount == 2){
			ObsticleRandom2();
		}
		
		if(ObsticleCount == 3){
			ObsticleRandom3();
		}
		
		if(ObsticleCount == 4){
			ObsticleRandom4();
		}
		
		if(ObsticleCount == 5){
			ObsticleRandom5();
		}

		//START 1 !!!

		if(RandomEnemy1 == 1){
			E1nemy1.SetActive(true);
			E1nemy2.SetActive(false);
			E1nemy3.SetActive(false);
			E1nemy4.SetActive(false);
			E1nemy5.SetActive(false);
		}
		
		if(RandomEnemy1 == 2){
			E1nemy1.SetActive(false);
			E1nemy2.SetActive(true);
			E1nemy3.SetActive(false);
			E1nemy4.SetActive(false);
			E1nemy5.SetActive(false);
		}
		
		if(RandomEnemy1 == 3){
			E1nemy1.SetActive(false);
			E1nemy2.SetActive(false);
			E1nemy3.SetActive(true);
			E1nemy4.SetActive(false);
			E1nemy5.SetActive(false);
		}
		
		if(RandomEnemy1 == 4){
			E1nemy1.SetActive(false);
			E1nemy2.SetActive(false);
			E1nemy3.SetActive(false);
			E1nemy4.SetActive(true);
			E1nemy5.SetActive(false);
		}

		if(RandomEnemy1 == 5){
			E1nemy1.SetActive(false);
			E1nemy2.SetActive(false);
			E1nemy3.SetActive(false);
			E1nemy4.SetActive(false);
			E1nemy5.SetActive(true);
		}
		//START 2 !!!

		if(RandomEnemy2 == 1){
			E2nemy1.SetActive(true);
			E2nemy2.SetActive(false);
			E2nemy3.SetActive(false);
			E2nemy4.SetActive(false);
			E2nemy5.SetActive(false);
		}
		
		if(RandomEnemy2 == 2){
			E2nemy1.SetActive(false);
			E2nemy2.SetActive(true);
			E2nemy3.SetActive(false);
			E2nemy4.SetActive(false);
			E2nemy5.SetActive(false);
		}
		
		if(RandomEnemy2 == 3){
			E2nemy1.SetActive(false);
			E2nemy2.SetActive(false);
			E2nemy3.SetActive(true);
			E2nemy4.SetActive(false);
			E2nemy5.SetActive(false);
		}

		if(RandomEnemy2 == 4){
			E2nemy1.SetActive(false);
			E2nemy2.SetActive(false);
			E2nemy3.SetActive(false);
			E2nemy4.SetActive(true);
			E2nemy5.SetActive(false);
		}

		if(RandomEnemy2 == 5){
			E2nemy1.SetActive(false);
			E2nemy2.SetActive(false);
			E2nemy3.SetActive(false);
			E2nemy4.SetActive(false);
			E2nemy5.SetActive(true);
		}

		//START 3 !!!

		if(RandomEnemy3 == 1){
			E3nemy1.SetActive(true);
			E3nemy2.SetActive(false);
			E3nemy3.SetActive(false);
			E3nemy4.SetActive(false);
			E3nemy5.SetActive(false);
		}
		
		if(RandomEnemy3 == 2){
			E3nemy1.SetActive(false);
			E3nemy2.SetActive(true);
			E3nemy3.SetActive(false);
			E3nemy4.SetActive(false);
			E3nemy5.SetActive(false);
		}
		
		if(RandomEnemy3 == 3){
			E3nemy1.SetActive(false);
			E3nemy2.SetActive(false);
			E3nemy3.SetActive(true);
			E3nemy4.SetActive(false);
			E3nemy5.SetActive(false);
		}

		if(RandomEnemy3 == 4){
			E3nemy1.SetActive(false);
			E3nemy2.SetActive(false);
			E3nemy3.SetActive(false);
			E3nemy4.SetActive(true);
			E3nemy5.SetActive(false);
		}

		if(RandomEnemy3 == 5){
			E3nemy1.SetActive(false);
			E3nemy2.SetActive(false);
			E3nemy3.SetActive(false);
			E3nemy4.SetActive(false);
			E3nemy5.SetActive(true);
		}

		//START 4 !!!


		if(RandomEnemy4 == 1){
			E4nemy1.SetActive(true);
			E4nemy2.SetActive(false);
			E4nemy3.SetActive(false);
			E4nemy4.SetActive(false);
			E4nemy5.SetActive(false);
		}
		
		if(RandomEnemy4 == 2){
			E4nemy1.SetActive(false);
			E4nemy2.SetActive(true);
			E4nemy3.SetActive(false);
			E4nemy4.SetActive(false);
			E4nemy5.SetActive(false);
		}
		
		if(RandomEnemy4 == 3){
			E4nemy1.SetActive(false);
			E4nemy2.SetActive(false);
			E4nemy3.SetActive(true);
			E4nemy4.SetActive(false);
			E4nemy5.SetActive(false);
		}

		if(RandomEnemy4 == 4){
			E4nemy1.SetActive(false);
			E4nemy2.SetActive(false);
			E4nemy3.SetActive(false);
			E4nemy4.SetActive(true);
			E4nemy5.SetActive(false);
		}

		if(RandomEnemy4 == 5){
			E4nemy1.SetActive(false);
			E4nemy2.SetActive(false);
			E4nemy3.SetActive(false);
			E4nemy4.SetActive(false);
			E4nemy5.SetActive(true);
		}

		//START 5 !!!

		if(RandomEnemy5 == 1){
			E5nemy1.SetActive(true);
			E5nemy2.SetActive(false);
			E5nemy3.SetActive(false);
			E5nemy4.SetActive(false);
			E5nemy5.SetActive(false);
		}
		
		if(RandomEnemy5 == 2){
			E5nemy1.SetActive(false);
			E5nemy2.SetActive(true);
			E5nemy3.SetActive(false);
			E5nemy4.SetActive(false);
			E5nemy5.SetActive(false);
		}
		
		if(RandomEnemy5 == 3){
			E5nemy1.SetActive(false);
			E5nemy2.SetActive(false);
			E5nemy3.SetActive(true);
			E5nemy4.SetActive(false);
			E5nemy5.SetActive(false);
		}

		if(RandomEnemy5 == 4){
			E5nemy1.SetActive(false);
			E5nemy2.SetActive(false);
			E5nemy3.SetActive(false);
			E5nemy4.SetActive(true);
			E5nemy5.SetActive(false);
		}

		if(RandomEnemy5 == 5){
			E5nemy1.SetActive(false);
			E5nemy2.SetActive(false);
			E5nemy3.SetActive(false);
			E5nemy4.SetActive(false);
			E5nemy5.SetActive(true);
		}
	}
}
