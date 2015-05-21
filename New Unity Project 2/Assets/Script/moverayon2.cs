using UnityEngine;
using System.Collections;

public class moverayon2 : MonoBehaviour {
	public float smooth = 0.01F;
	public float tiltAngle = 180F;
	public float tiltAngle2 = 340F;

	//	public Quaternion rotation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//float angle = Time.deltaTime;
		//angle = Mathf.Lerp (330, 30, angle / Time.deltaTime);
		float tiltAroundZ = Input.GetAxis ("Horizontal") * tiltAngle;
		float tiltAroundX = Input.GetAxis ("Vertical") * tiltAngle;
		Quaternion target = Quaternion.Euler (0, 0, tiltAngle);
		Quaternion target2 = Quaternion.Euler (0, 0, tiltAngle2);

		transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
	//	transform.rotation = Quaternion.Slerp(transform.rotation, target2, Time.deltaTime * smooth);

		//transform.rotation = Quaternion.identity;
		if (transform.rotation == target2) {
			float translation = Time.deltaTime * 0.1F;
			transform.Translate (0, -translation, 0);

		}

			
		
	}

	void FixedUpdate () {

		//float angle = 0; 

		//for (float i= -30; i= angle; ++i){
		//	angle += 1;
	//	transform.rotation = Quaternion.Euler (0, 0, angle);
		//}
	}
}
