using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MadebyMe : MonoBehaviour {

    public Text Madebyme;

    // Use this for initialization
	void Start () {
        Madebyme.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("k"))
        {
            Madebyme.enabled = true;
        }
        if (Input.GetKey("l"))
        {
            Madebyme.enabled = false;
        }
    }
}
