#pragma strict

var Touchesol:boolean;
var anim:Animator;
var touch:boolean;

function Start () {

}

function Update () {

	transform.rotation.x = 0;
	transform.rotation.y = 0;
	transform.rotation.z = 0;
	
	anim.SetBool("Marche",true);
	anim.SetBool("Jump",false);

//	if(Input.GetKeyDown(KeyCode.Space)){
	//anim.SetBool("Marche",false);
	//anim.SetBool("Jump",true);
//	GetComponent<Rigidbody2D> ().AddForce (Vector2.up * 300f);
	
//	}
	
	if(Input.GetKey(KeyCode.RightArrow)){
	
	//anim.SetBool("Marche",true);
	transform.Translate(Vector2(0.1,0));
	transform.localScale.x = 0.6;
	
	}
	
	if(Input.GetKey(KeyCode.LeftArrow)){
	
	anim.SetBool("Marche",true);
	transform.Translate(Vector2(-0.1,0));
	transform.localScale.x = -0.6;
	
	
	}
	
		
		}
