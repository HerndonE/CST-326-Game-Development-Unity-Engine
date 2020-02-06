﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleHit : MonoBehaviour
{
    public string objectName = "player";
    public static float increaseSpeed = 100.0f;
    public AudioClip otherClip;
    private void OnCollisionEnter(Collision col)
    {
        {

            if (col.gameObject.tag == objectName)
            {
                Debug.Log("Ball Hit");
                increaseSpeed+=BallMovement.speed;
                Debug.Log(increaseSpeed);
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip;
                audio.Play();
            }

        }

    }
}
