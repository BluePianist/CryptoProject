using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	GameObject ennemis;
	public bool choc = false;

	// Use this for initialization
	void Start () {

		ennemis = GameObject.Find ("Enemies");
	
	}
	
	// Update is called once per frame
	void Update () {

		int fingerCount = 0;

		foreach (Touch touch in Input.touches) {
			if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
				fingerCount++;
			
			
				if (fingerCount == 2) {
				print ("User has " + fingerCount + " finger(s) touching the screen");
				GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 300f);
				GetComponent<Rigidbody2D> ().AddForce (Vector2.right * 100f);

			}
			if (fingerCount == 3) {
				print ("User has " + fingerCount + " finger(s) touching the screen");
				GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 400f);
				GetComponent<Rigidbody2D> ().AddForce (Vector2.right * 200f);
				
			}
			if (fingerCount == 4) {
				print ("User has " + fingerCount + " finger(s) touching the screen");
				GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 400f);
				GetComponent<Rigidbody2D> ().AddForce (Vector2.right * 400f);
				
			}
			if (fingerCount == 5) {
				print ("User has " + fingerCount + " finger(s) touching the screen");
				GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 400f);
				GetComponent<Rigidbody2D> ().AddForce (Vector2.right * 600f);
				
			}
		}
	
	}

	void OnCollisionEnter2D (){

		choc = true;

	}

	void OnCollisionExit2D (){

		choc = false;
		
	}
}
