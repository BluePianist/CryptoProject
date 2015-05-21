using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 0.1F;

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0)) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 300f);

		}

			int fingerCount = 0;
			foreach (Touch touch in Input.touches) {
				if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
					fingerCount++;
				
			}
			if (fingerCount > 0) {
			print ("User has " + fingerCount + " finger(s) touching the screen");
		}
			
		
		
		
		
	}
}
