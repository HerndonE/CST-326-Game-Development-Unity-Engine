using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class lifeScript : MonoBehaviour {

    public GameObject player;
    public GameObject yesContinue;
   // public Image something;
    void Awake()
    {
       
       // something.enabled = false;
        yesContinue.SetActive(false);
    }

	// Use this for initialization
	void Start () {
        
        
    }
	
	// Update is called once per frame
	void Update () {
        
        if (player.gameObject ==  false)
        {
            //something.enabled = true;
            yesContinue.SetActive(true);


        }

    }
}
