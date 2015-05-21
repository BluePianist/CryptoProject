using UnityEngine;
using System.Collections;

public class Optionbutton : MonoBehaviour {

	public Texture BtnTexure;
	public GUIStyle style;
	public GUISkin skin;
	public float left = 450f;
	public float top = 450f;
	public float width = 450f;
	public float height = 450f;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	/*	if (Input.GetMouseButtonUp (0)) {

			Application.LoadLevel("Options");


		}
	*/
	}

	void OnGUI () {

		if (GUI.Button (new Rect (left, top, width, height), "Options")) {
		Application.LoadLevel ("Options");

	}
	}
}
