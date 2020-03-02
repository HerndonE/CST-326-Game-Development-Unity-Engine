using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
   
    public AudioClip otherClip;  
    public bool isOn = false;
    public GameObject foo;

    void Start()
    {
        //Debug.Log("Start ok");

    }

    // Update is called once per frame
    void Update()
    {
      
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            if (isOn == false)
            {
                isOn = true;
                Debug.Log("ok");
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip;
                audio.Play();
            }
        }
        else
            isOn = false;

  
        //Debug.Log("ok2");



    }
}
