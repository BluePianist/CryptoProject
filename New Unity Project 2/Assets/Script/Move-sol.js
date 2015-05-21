#pragma strict

function Start () {

}

function Update () {

	transform.Translate(Vector2(-0.2,0));
	
	if(transform.position.x < -10){
	
	transform.position.x = 54;
	
	}
	

}