using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

	public Transform explosion;
	public bool isenabled;
	public ParticleSystem ps;


	// Use this for initialization
	void Start () {
		ps = explosion.GetComponent<ParticleSystem> ();
		ps.gameObject.SetActive( !isenabled);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void OnTriggerEnter(Collider Other){

		if (Other.gameObject.tag == "Rocket") {
			ps.gameObject.SetActive(isenabled);
			ps.Play ();
			StartCoroutine (stopExplosion ());
			Destroy (gameObject);
		}
	}
	IEnumerator stopExplosion(){
		yield return new WaitForSeconds (.4f);
		ps.gameObject.SetActive(!isenabled);
	}

		
}
