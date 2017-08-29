using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackHoleGoal : MonoBehaviour {


	//public Text ScoreText, LevelText;

	public static int score;
	public int sceneToChangeTo;


	void Start (){

		//ScoreText = GetComponent <Text> (); this was resetting the text object everytime
		//score = 0;


	}

	void Update (){


		if(ScoreManager.Instance)ScoreManager.Instance.scoreNumber.text = "" + ScoreManager.Instance.score.ToString(); 

	}

	// Use this for initialization
	void OnTriggerEnter (Collider Other) {


		if (Other.gameObject.tag == "Planet") {

			if (ScoreManager.Instance)ScoreManager.Instance.score = ScoreManager.Instance.score + 100;

				Destroy (GameObject.FindWithTag ("Planet"));

			StartCoroutine (TextWait());




		}
		 
		if (Other.gameObject.tag == "Rocket") {

			//if (ScoreManager.Instance)ScoreManager.Instance.score = ScoreManager.Instance.score + 25;

			Destroy (GameObject.FindWithTag ("Rocket"));
		
		}

		if (Other.gameObject.tag == "Sun") {

			Destroy (GameObject.FindWithTag ("Sun"));

			StartCoroutine (YouWon());
		}

					
	}
		

	IEnumerator TextWait(){
		yield return new WaitForSeconds (2.0f);
		ScoreManager.Instance.levelText.text = "Level Up!";
		yield return new WaitForSeconds (3.0f);
		ScoreManager.Instance.levelText.text = "";
		UnityEngine.SceneManagement.SceneManager.LoadScene(sceneToChangeTo);
		yield return null;

	}

	IEnumerator YouWon(){
		yield return new WaitForSeconds (2.0f);
		ScoreManager.Instance.levelText.text = "You Destroyed the Solar System, Our Only Home";
		yield return null;
	}

	
}
