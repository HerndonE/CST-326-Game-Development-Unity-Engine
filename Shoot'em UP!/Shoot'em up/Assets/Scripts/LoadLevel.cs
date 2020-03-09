using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	public void Load(int level){
		Application.LoadLevel(level);
	}
	public void LoadNextLevel(){
		Application.LoadLevel(Application.loadedLevel + 1 % Application.levelCount);
	}
}
