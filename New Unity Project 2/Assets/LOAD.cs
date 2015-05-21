using UnityEngine;
using System.Collections;

public class LOAD : MonoBehaviour {
	public bool Play = false;
	public bool Options = false;
	public bool Retour = false;
	private Animator load;

	void Awake (){
		
		load = GetComponent<Animator> ();
		
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void OnClickPlay (){

		Application.LoadLevel ( "level3" );

			}
	public void OnClickOptions (){
		
		Application.LoadLevel ( "Options" );
	}
	public void OnClickRetour (){
		
		Application.LoadLevel ( "Menu" );
	}
}
