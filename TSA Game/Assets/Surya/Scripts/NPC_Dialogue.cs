using UnityEngine;
using System.Collections;

public class NPC_Dialogue : MonoBehaviour {
	public string [] answerButtons;
	public string [] Questions;
	bool DisplayDialogue = false;
	bool ActivateQuest = false;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter () {

		DisplayDialogue = true;
	}
	
	void OnTriggerExit (){
		DisplayDialogue = false;

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
					
					DisplayDialogue = false;
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
}
