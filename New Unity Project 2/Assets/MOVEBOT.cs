using UnityEngine;
using System.Collections;

public class MOVEBOT : MonoBehaviour {
	public float speed = 2f;
	bool choc = false;
	private Animator anime;

	void Awake (){
		
		anime = GetComponent<Animator> ();
		
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		anime.SetBool("Dead",false);


		if ((choc)){
		transform.Translate (-Vector2.right * Time.deltaTime * speed);
	
		}

		int fingerCount = 0;
		
		foreach (Touch touch in Input.touches) {
			if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
				fingerCount++;

			if (fingerCount == 2) {
				print ("User has " + fingerCount + " finger(s) touching the screen");
				GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 300f);
				GetComponent<Rigidbody2D> ().AddForce (Vector2.right * 100f);
				anime.SetBool("Dead",true);
				transform.Translate (-Vector2.right * Time.deltaTime * 0);

			
			}
			if (fingerCount == 3) {
				print ("User has " + fingerCount + " finger(s) touching the screen");
				GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 400f);
				GetComponent<Rigidbody2D> ().AddForce (Vector2.right * 200f);
				anime.SetBool("Dead",true);
				transform.Translate (-Vector2.right * Time.deltaTime * 0);

			
			}
			if (fingerCount == 4) {
				print ("User has " + fingerCount + " finger(s) touching the screen");
				GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 400f);
				GetComponent<Rigidbody2D> ().AddForce (Vector2.right * 400f);
				anime.SetBool("Dead",true);
				transform.Translate (-Vector2.right * Time.deltaTime * 0);


			}
			if (fingerCount == 5) {
				print ("User has " + fingerCount + " finger(s) touching the screen");
				GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 400f);
				GetComponent<Rigidbody2D> ().AddForce (Vector2.right * 600f);
				anime.SetBool("Dead",true);
				transform.Translate (-Vector2.right * Time.deltaTime * 0);


			}
		}
	}

	void OnCollisionEnter2D(){
	
		choc = true;
	}

	void OnCollisionExit2D(){

		choc = false;
	}
}
