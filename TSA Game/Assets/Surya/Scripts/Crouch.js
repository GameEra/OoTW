#pragma strict

function Start () {

}

function Update () {

	 if(Input.GetKey(KeyCode.LeftControl))
     {
         transform.localPosition = Vector3(0, 0, 0);
     }
     else
     {
         transform.localPosition = Vector3(0, .8, 0);
     }

}