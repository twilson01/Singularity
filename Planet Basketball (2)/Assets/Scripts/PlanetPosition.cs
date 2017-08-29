using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetPosition : MonoBehaviour {

public Vector3 StartPosition;

	// Use this for initialization
	void Start () {
		StartPosition = transform.position;
		
	}
	
	// Update is called once per frame
	public void ResetPosition () {
		Debug.Log ("Should Reset: " + transform.name);
		transform.GetComponent<Rigidbody> ().velocity = Vector3.zero;
		transform.position = StartPosition;
		
	}
}
