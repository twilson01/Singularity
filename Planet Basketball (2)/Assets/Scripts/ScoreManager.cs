using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static ScoreManager Instance;

	public Text scoreText, scoreNumber, levelText;

	public int score = 0;

	// Use this for initialization
	void Start () {
		Instance = this;
		DontDestroyOnLoad (this);
	}
	
	// Update is called once per frame
	void Update () {

		if (scoreText == null)
			scoreText = GameObject.Find ("ScoreText").GetComponent<Text> ();
		if (scoreNumber == null)
			scoreNumber = GameObject.Find ("ScoreNumber").GetComponent<Text> ();
		if (levelText == null)
			levelText = GameObject.Find ("LevelUp").GetComponent<Text> ();

	}
}
