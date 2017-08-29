using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {

	Text text;
	public static float timeleft = 45f;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		timeleft -= Time.deltaTime;
		if (timeleft < 0) {
			timeleft = 0;
			StartCoroutine (Fail());
		}
		text.text = "Countdown: " + Mathf.Round (timeleft);
	}

	IEnumerator Fail(){
		yield return new WaitForSeconds (2.0f);
		ScoreManager.Instance.levelText.text = "Mission Fail. ReInitiate.";
		yield return new WaitForSeconds (3.0f);
		ScoreManager.Instance.levelText.text = "";
		timeleft = 45f;
		UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex ) ;
		yield return null;
	}
}
