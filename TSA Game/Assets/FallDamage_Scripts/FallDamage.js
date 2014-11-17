#pragma strict

var lastPositionY : float = 0f;
var fallDistance : float = 0f;
var player : Transform;

private var controller : CharacterController;

var currentHealth : float = 10.0f;

function Start()
{
	controller = GameObject.Find("Player").GetComponent(CharacterController);
}
     
function Update ()
{	
    if(lastPositionY > player.transform.position.y)
    {
    	fallDistance += lastPositionY - player.transform.position.y;
    }
    
    lastPositionY = player.transform.position.y;
    
    if(fallDistance >= 15 && controller.isGrounded)
    {
    	currentHealth -= 5;
    	ApplyNormal();
    }
     
    if(fallDistance <= 15 && controller.isGrounded)
    {
    	ApplyNormal();
    }
}

function ApplyNormal()
{
    	fallDistance = 0;
        lastPositionY = 0;
}

function OnGUI()
{
	GUI.Box(Rect(10, 20, 80, 20),"Health = " + currentHealth);
}