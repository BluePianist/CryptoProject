using UnityEngine;
using System.Collections;

public class cameratracker : MonoBehaviour {

	Transform player;
	float offsetX;

	// Use this for initialization
	void Start () {

		GameObject playerGO = GameObject.FindGameObjectWithTag ("Player");
		player = playerGO.transform;
		offsetX = transform.position.x - player.position.x;
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 pos = transform.position;
		if (player.position.x > -9) {
			pos.x = player.position.x + offsetX;
			transform.position = pos;
		}
	
	}
}
