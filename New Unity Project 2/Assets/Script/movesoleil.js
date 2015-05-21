#pragma strict

function Start () {

}

function Update () {

	if (Input.GetKey(KeyCode.RightArrow)){

	transform.Translate(Vector2(-0.005,0));
	 }
	
	if (Input.GetKey(KeyCode.LeftArrow)){
	
		transform.Translate(Vector2(0.005,0));

	    }
	
	if(transform.position.x < -20){
	
	Destroy(gameObject);
	
	}
	

}