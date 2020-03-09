using UnityEngine;
using System.Collections;

public class LoadNextLevelOnTrigger : MonoBehaviour {
	public float delay = 0.0f;

  	IEnumerator LoadLevelAfterDelay(){
		yield return new WaitForSeconds (delay);
		Application.LoadLevel ((Application.loadedLevel + 1) % Application.levelCount);
	}

	void OnTriggerEnter(){
		StartCoroutine (LoadLevelAfterDelay ());
	}
	void OnTriggerEnter2D(){
		StartCoroutine (LoadLevelAfterDelay ());
	}
}
