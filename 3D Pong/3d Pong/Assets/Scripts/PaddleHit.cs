using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleHit : MonoBehaviour
{
    public string objectName = "player";
    public static float increaseSpeed = 5.0f;
    public AudioClip otherClip;
    private void OnCollisionEnter(Collision col)
    {
        {

            //increaseSpeed += 100;

            if (col.gameObject.tag == objectName)
            {
               
                //Debug.Log("Ball Hit");
              increaseSpeed +=BallMovement.speed;
               // Debug.Log("Speed" + increaseSpeed);
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip;
                audio.Play();
            }

        }

    }
}
