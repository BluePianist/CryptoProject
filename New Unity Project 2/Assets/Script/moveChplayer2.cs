using UnityEngine;
using System.Collections;

public class moveChplayer2 : MonoBehaviour {

	GameObject ennemi;
	public float speed = 0.1F;
	private Animator anim;
	public bool Touchesol=false;
	public Vector3 pos = Input.acceleration;


	void Awake (){
	
		anim = GetComponent<Animator> ();
	
	}
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		var dir = Vector3.zero;
		anim.SetBool ("Marche", false);
		anim.SetBool ("Jump", false);
		anim.SetBool ("Sword", false);


		dir.x = Input.acceleration.x;
        dir.y = 0;
		dir.z = 0;

		if (dir.sqrMagnitude > 1) {
			dir.Normalize();
		
		}
		if (dir.x < -0.1) {
			transform.localScale = new Vector3 ( -3, transform.localScale.y, transform.localScale.z);
			anim.SetBool("Marche",true);
		}
		if (dir.x > 0.1) {
			transform.localScale = new Vector3 ( 3, transform.localScale.y, transform.localScale.z);
			anim.SetBool("Marche",true);

		}

		if (dir.x > 0.1 || dir.x < -0.1) {
			dir *= Time.deltaTime;
			transform.Translate (dir * 15);
		}
		
	/*	if (Input.GetKeyDown (KeyCode.Space)){ //|| Input.GetMouseButtonDown (0)) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 400f);

		} */

		int fingerCount = 0;
		float distance = 0.1f;
		var diff = Vector2.zero;

		diff.x = GameObject.FindGameObjectWithTag ("Enemy").transform.position.x - transform.position.x;
		diff.y = GameObject.FindGameObjectWithTag ("Enemy").transform.position.y - transform.position.y;
		
		foreach (Touch touch in Input.touches) {
			if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
				fingerCount++;

			if (fingerCount == 2){
			print ("User has " + fingerCount + " finger(s) touching the screen");
				anim.SetBool ("Sword", true);
				GameObject.FindGameObjectWithTag("Enemy").GetComponent<Rigidbody2D> ().AddForce (Vector2.right * 50f);
				GameObject.FindGameObjectWithTag("Enemy").GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 100f);


			}

		if (fingerCount == 1 && touch.phase == TouchPhase.Began && touch.phase != TouchPhase.Canceled && (Touchesol)) {
			print ("User has " + fingerCount + " finger(s) touching the screen");
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 600f);
				anim.SetBool("Jump",true); 
			} 
		}
		if (fingerCount == 0) {
			print ("User has " + fingerCount + " finger(s) touching the screen");
			transform.Translate ( Vector2.right * Time.deltaTime * 0);

			}
		
		
	}

	void OnGUI () {

		int fingerCount = 0;
		



	/*	hSliderValue = GUI.HorizontalSlider (new Rect (25, 250, 100, 30), hSliderValue, 0.0f, 10f);
	
		if (hSliderValue > 5f) {
			transform.Translate (Vector2.right * 2 * Time.deltaTime);
		
		} 
		else if (hSliderValue < 5f) {

			transform.Translate (-Vector2.right * 2 * Time.deltaTime);

		}

			else if (hSliderValue < 5 && fingerCount == 2){
			transform.Translate (-Vector2.right * 2 * Time.deltaTime);
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 200f);

			}
		

		if (GUI.RepeatButton (new Rect (25, 430, 100, 30), "Button") && (Touchesol)) {
		 	GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 500f);  
			anim.SetBool("Jump",true); 
		
		}
		if (GUI.RepeatButton (new Rect (400, 450, 100, 30), "Button")) {
			anim.SetBool ("Sword", true);
			GameObject.FindGameObjectWithTag("Enemy").GetComponent<Rigidbody2D> ().AddForce (Vector2.right * 200f);
			GameObject.FindGameObjectWithTag("Enemy").GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 100f);
		}
*/
	
	}

	void OnCollisionEnter2D(){

		Touchesol = true;

		}

	void OnCollisionExit2D(){

		Touchesol = false;

	}



		
}
   
