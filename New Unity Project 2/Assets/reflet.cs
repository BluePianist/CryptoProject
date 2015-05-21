using UnityEngine;
using System.Collections;

public class reflet : MonoBehaviour {

	public float speedreflet = 0.1f;
	public float speedmontreflet = 0.1f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.localScale.y > 0) {
			transform.localScale = new Vector3 (transform.localScale.x - Time.deltaTime * speedreflet / 2, transform.localScale.y - Time.deltaTime * speedreflet, 1);
			transform.Translate (-Vector2.up * Time.deltaTime * speedmontreflet);

		}
	}
}
