using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScenes : MonoBehaviour {
	
	// Update is called once per frame
	public void ChangeToScene (int SceneToChangeTo) {
		Application.LoadLevel(SceneToChangeTo);
		//SceneManager.LoadScene(SceneToChangeTo);
		
	}
}
