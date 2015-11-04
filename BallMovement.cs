using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {

	public GameObject Trail;
	public GameObject Ball;
	public Rigidbody2D rb;
	public Animator BallAnim;
	public Animator TrailAnim;
	public Animator EndScreenAnim;

	public GameObject Shield;
	public GameObject ShieldPickUp;
	public GameObject StartScreenTutorial;
	public bool ShieldBool = false;
	public AudioClip[] 	audioClip;
	public static bool IsDead = false;
	public static bool EndFadeOutBool;
	public Transform BallParticle;
	public GameObject ShieldPickUpPart1;
	public GameObject ShieldPickUpPart2;
	public GameObject ShieldPickUpPart3;
	public GameObject EndScreen;



			int ShieldCount = 0;
						
			float BallSpeed = 1.5f;

					// Use this for initialization
		void Start () {
				PlaySound(0);
				rb = GetComponent<Rigidbody2D>();
				ShieldCount = 0;
				Shield.SetActive(false);
				ShieldPickUp.SetActive(true);
				ShieldBool = false;
				IsDead = false;
				EndFadeOutBool = false;

				Vector3 pos = ShieldPickUp.transform.position;
				pos.y = Random.Range(20,50);
				ShieldPickUp.transform.position = pos;



			}

					// Up Movement
			void FixedUpdate () {

				rb.AddForce(Vector2.up * BallSpeed);
						
				Vector3 BallPos = Ball.transform.position;
				BallPos.x = 0f;
				Ball.transform.position = BallPos;

				}

			IEnumerator BallForce() {

				BallSpeed = 6f;
				yield return new WaitForSeconds (0.3f);
				BallSpeed = 2f;

			}

			IEnumerator ShieldCoroutine() {
						
				yield return new WaitForSeconds(1f);
						
				ShieldCount = 1;
						
			}

			IEnumerator BallDestruction() {

				yield return new WaitForSeconds(0.1f);
				
				Ball.SetActive(false);

			EndScreenAnim.SetBool("ActivateEndScreen", true);
				

		}
					

	public void PlaySound(int clip){
		GetComponent<AudioSource>().clip = audioClip[clip];
		GetComponent<AudioSource>().Play();
	}



		void Update(){

			if(Shield.activeSelf){

					ShieldPickUpPart1.SetActive(false);
					ShieldPickUpPart2.SetActive(false);
					ShieldPickUpPart3.SetActive(false);
							
				}else{

					ShieldPickUpPart1.SetActive(true);
					ShieldPickUpPart2.SetActive(true);
					ShieldPickUpPart3.SetActive(true);
							
			}


				if(Input.GetMouseButton(0)){

					StartScreenTutorial.SetActive(false);

						BallSpeed = 0.3f;
							 
						BallAnim.SetInteger("isHeld", 1);
						BallAnim.SetInteger("Released", 0);
						BallAnim.SetBool("Holding", true);

						TrailAnim.SetInteger("TrailFade", 1);
						TrailAnim.SetInteger("TrailRelease", 0);

				}else{

						StartCoroutine(BallForce());

						TrailAnim.SetInteger("TrailFade", 0);
						TrailAnim.SetInteger("TrailRelease", 1);
							
						BallAnim.SetBool("Holding", false);
						BallAnim.SetInteger("isHeld", 0);
						BallAnim.SetInteger("Released", 1);
				}

		}

				void OnCollisionEnter2D(Collision2D collision){
	
		if(collision.collider.CompareTag("Enemy") && ShieldCount == 1){

						Instantiate(BallParticle,transform.position,transform.rotation);
						IsDead = true;
						StartCoroutine(BallDestruction());
						PlaySound(1);	
					//make ball invisible and still (like Destroy())
							
						}

				if(collision.collider.CompareTag("Enemy") && !ShieldScript.PickedUpShield && ShieldCount == 0){

				Instantiate(BallParticle,transform.position,transform.rotation);
				IsDead = true;
				StartCoroutine(BallDestruction());
				PlaySound(1);	
			
				//make ball invisible and still (like Destroy())
							
							
			}

			 if(ShieldScript.PickedUpShield){
				//When balls hits obstacle with shield on 

				Shield.SetActive(false);

				StartCoroutine(ShieldCoroutine());
						
			}	



		}

		void OnTriggerEnter2D(Collider2D collider){

			if(collider.CompareTag("Shield")){

			//StartCoroutine(PickUpCoroutine());
			Shield.SetActive(true);

			ShieldCount = 0;

			Vector3 pos = collider.transform.position;
							
			pos.y += Random.Range(50,100);
				
			collider.transform.position = pos;

		//ShieldCount = 0;

			}
		}

	}




