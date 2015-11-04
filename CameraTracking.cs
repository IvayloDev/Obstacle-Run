using UnityEngine;
using System.Collections;

public class CameraTracking : MonoBehaviour {

	Transform player;
	float offSetY;
	// Use this for initialization
	void Start () {
		
		GameObject player_go = GameObject.FindGameObjectWithTag("Ball");
		
		
		if(player_go == null){
			
			Debug.Log("Player not found!");
			return;
		}
		
		player = player_go.transform;
		
		offSetY = transform.position.y - player.position.y;
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if(player != null){
			
			Vector3 pos = transform.position;
			pos.y = player.position.y + offSetY;
			transform.position = pos;
			
		}
		
	}
}
