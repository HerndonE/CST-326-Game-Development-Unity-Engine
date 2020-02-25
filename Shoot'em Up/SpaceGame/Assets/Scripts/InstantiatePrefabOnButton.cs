using UnityEngine;
using System.Collections;

public class InstantiatePrefabOnButton : MonoBehaviour {

	public GameObject prefab;
	public string buttonName = "Fire1";

	// Update is called once per frame
	void Update () {
       
        if (Input.GetButtonDown(buttonName))
        {
     
            GameObject newCrate = GameObject.Instantiate(prefab, transform.position, transform.rotation) as GameObject;
        }
        }	
}



