using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour {

	void OnTriggerEnter (Collider Other){
		if(Other.gameObject.tag == "Enemy"){
			Destroy(Other.gameObject);
		

		}
	}


}
