#pragma strict


//Teast

function Start () {

}

function Update () {

	if(Input.GetButtonDown("Fire1"))
	{
		animation.Play("Hit");
	}

}