using UnityEngine;
using System.Collections;
using UnityEngine.UI;

// attach to UI Text component (with the full text already there)

public class UITextTypeWriter : MonoBehaviour {

	Text txt;
	string story;

	public float timeToWait;

	void Awake () 
	{
		txt = GetComponent<Text> ();
		story = txt.text;
		txt.text = "";

		// TODO: add optional delay when to start
		//WaitForSeconds (timeToWait);
		StartCoroutine ("PlayText");
	}

	IEnumerator PlayText()
	{
		foreach (char c in story) 
		{
			txt.text += c;
			yield return new WaitForSeconds (timeToWait);
		}
	}

}