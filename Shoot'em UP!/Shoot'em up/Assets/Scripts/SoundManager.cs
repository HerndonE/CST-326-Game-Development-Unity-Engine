using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    float timer = 0.0f;
    public AudioClip otherClip;
    public AudioClip otherClipTwo;
    public bool isOn = false;
    public bool isOnEnemy = true;
    
    void Start()
    {
        //Debug.Log("Start ok");
        isOnEnemy = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 4.0f)
        {

            if (GameObject.FindGameObjectWithTag("enemy") == null)
            {
                if (isOnEnemy == true)
                {
                    isOnEnemy = false;
                    Debug.Log("ok");
                    AudioSource audio = GetComponent<AudioSource>();
                    audio.clip = otherClipTwo;
                    audio.Play();
                }
            }

       
        }
        else
            isOnEnemy = true;



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
