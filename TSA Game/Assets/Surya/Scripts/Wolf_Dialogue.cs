﻿using UnityEngine;
using System.Collections;

public class Wolf_Dialogue : MonoBehaviour {
	public string [] answerButtons;
	public string [] Questions;
	bool DisplayDialogue = false;
	bool ActivateQuest = false;
	public Transform wolfSon;



	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter () {

		DisplayDialogue = true;
		GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = false;
		GameObject.Find("Player").GetComponent<MouseLook>().enabled = false;
	}
	
	void OnTriggerExit (){
		DisplayDialogue = false;
		GameObject.Find("Main Camera").GetComponent<MouseLook>().enabled = true;
		GameObject.Find("Player").GetComponent<MouseLook>().enabled = true;

	}


	void OnGUI()
	{

		GUILayout.BeginArea (new Rect(700,600,400,500));
			if (DisplayDialogue && !ActivateQuest) {
				GUILayout.Label(Questions[0]);
				if(GUILayout.Button(answerButtons[0])){
				
					DisplayDialogue = false;
				}

				if(GUILayout.Button(answerButtons[1])){
					DisplayDialogue = false;
				}

				if(GUILayout.Button(answerButtons[2])){
					ActivateQuest = true;
	//				GameObject.Find("RabbitTrap").active = false;
	//				Pause ();
					DisplayDialogue = false;
				GameObject c = GameObject.Find("WeaponManager");
					CompassScript compass = c.GetComponent<CompassScript>();
					compass.target = wolfSon;
				}

			}
			
			if (DisplayDialogue && ActivateQuest) {
				GUILayout.Label(Questions[1]);
				if(GUILayout.Button (answerButtons[3])){
				DisplayDialogue = false;
				}
			}
		GUILayout.EndArea();
		}
	IEnumerator Pause ()
	{
		yield return new WaitForSeconds(26f);
		}
}
