using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class pauseGame : MonoBehaviour {

    private bool Pause = false;
    private bool showGUI = false;
    public RawImage pauseImage;
    GameObject pauseAbortMission;
    
     void Start()
    {

    }


    void Update()
    {
       
        if (Input.GetKeyDown("escape"))
        {
            Pause = !Pause;
            GameObject.Find("ObjectShoot").GetComponent<InstantiatePrefabOnButton>().enabled = true;
            GameObject.Find("ObjectShoot").GetComponent<RocketCooldown>().enabled = true;
            GameObject.FindWithTag("Player").GetComponent<leftnRight>().enabled = true;
            //Debug.Log("Unpause Game!");
            if (Pause == true)
            {
                Time.timeScale = 0;
                GameObject.Find("ObjectShoot").GetComponent<InstantiatePrefabOnButton>().enabled = false;
                GameObject.Find("ObjectShoot").GetComponent<RocketCooldown>().enabled = false;
                GameObject.FindWithTag("Player").GetComponent<leftnRight>().enabled = false;
                Pause = true;
                pauseImage.enabled = true;               
                Debug.Log("Pause Game!");
            }
        }

        if (Pause == false)
        {
            Time.timeScale = 1;
           // GameObject.Find("ObjectShoot").GetComponent<InstantiatePrefabOnButton>().enabled = true;
           // GameObject.Find("ObjectShoot").GetComponent<RocketCooldown>().enabled = true;
           // GameObject.FindWithTag("Player").GetComponent<leftnRight>().enabled = true;
            Pause = false;
            pauseImage.enabled = false;     
         }
       

    }

}
