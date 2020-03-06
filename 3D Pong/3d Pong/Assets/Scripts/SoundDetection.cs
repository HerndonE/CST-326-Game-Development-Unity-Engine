using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundDetection : MonoBehaviour
{

    public AudioClip otherClip;
    public AudioClip otherClip2;
    public AudioClip otherClip3;
    public AudioClip otherClip4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {  // get the direction of the collision
        Vector3 direction = transform.position - col.gameObject.transform.position;
        // see if the obect is futher left/right or up down
        if (Mathf.Abs(direction.x) > Mathf.Abs(direction.y))
        {

            if (direction.x > 0) {
                print("collision is to the right");
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip;
                audio.Play();
            }
            else {
                print("collision is to the left");
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip2;
                audio.Play();
            }

        }
        else
        {

            if (direction.y > 0) {
                print("collision is up");
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip3;
                audio.Play();
            }
            else {
                print("collision is down");
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip4;
                audio.Play();
            }

        }
    }
}
//Reference https://answers.unity.com/questions/377616/how-to-detect-which-side-of-a-box-collider-was-hit.html