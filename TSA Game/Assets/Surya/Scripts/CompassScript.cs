using UnityEngine;
using System.Collections;

public class CompassScript : MonoBehaviour {
	public Transform target;
	public Transform compass;

	void Update () {
		
		compass.transform.LookAt(target);
	
	}
}
