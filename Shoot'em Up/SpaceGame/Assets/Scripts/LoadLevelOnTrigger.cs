using UnityEngine;
using System.Collections;

public class LoadLevelOnTrigger : MonoBehaviour {
	public int level;
	public float delay = 0.0f;

  	IEnumerator LoadLevelAfterDelay(){
		yield return new WaitForSeconds (delay);
		Application.LoadLevel (level);
	}

	void OnTriggerEnter(){
		StartCoroutine (LoadLevelAfterDelay ());
	}
	void OnTriggerEnter2D(){
		StartCoroutine (LoadLevelAfterDelay ());
	}
}
