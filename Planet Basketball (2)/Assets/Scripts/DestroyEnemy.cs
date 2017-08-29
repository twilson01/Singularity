using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour {

	public GameObject explosion;
	//public AudioClip explode;

	//void Start(){
		//GetComponent<AudioSource> ().playOnAwake = false;
		//GetComponent<AudioSource> ().clip = explode;
	//}

	void OnTriggerEnter (Collider Other){
		
		if(Other.gameObject.tag == "Enemy"){

			GameObject ps = Instantiate (explosion, Other.transform.position, Quaternion.identity) as GameObject;
			Destroy (ps, 4f);
			//GetComponent<AudioSource>().Play();
			//Destroy (gameObject);
			Destroy (Other.gameObject); //this line works
		

		}
	}


}
