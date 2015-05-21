using UnityEngine;
using System.Collections;

public class movesoleiiiil : MonoBehaviour { 
	public float smooth = 0.01F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		
		float translation = Time.deltaTime / -10;
		transform.Translate (translation, 0, 0);

	
	}
}
