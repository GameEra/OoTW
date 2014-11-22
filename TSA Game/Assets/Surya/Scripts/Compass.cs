using UnityEngine;
using System.Collections;

public class Compass : MonoBehaviour {
	public Transform target;
	

	void Update () {
		
		transform.LookAt(target);
	
	}
}
