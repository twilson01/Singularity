using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boarder : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider Other) {

		if(Other.gameObject.tag == "Planet"){
			Other.gameObject.GetComponent<PlanetPosition>().ResetPosition();
			//reset to original position
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
