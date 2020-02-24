using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player1 : MonoBehaviour
{


    public Text scoreText;
    public Text coinText;
    public int points = 0;
    public int coinPoints = 0;

    public AudioClip otherClip;
   


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.name == "Brick(Clone)")
        {
            Destroy(collision.gameObject);
            Debug.Log("We heed your call");
            points = points + 100;
            //scoreText.text = "" + points;
            scoreText.text = "0000" + points;

            if (points >= 99)
            {

                scoreText.text = "00" + points;
            }
        }
        if (collision.gameObject.name == "QuestionV2 1(Clone)")
        {
            Destroy(collision.gameObject);
            Debug.Log("We heed your call");
            coinPoints = coinPoints + 1;
            coinText.text = "x " + coinPoints;
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = otherClip;
            audio.Play();
            

        }

        if (collision.gameObject.name == "Water(Clone)")
        {
            Destroy(GameObject.Find("Ethan"));
        }

        if (collision.gameObject.name == "Winner(Clone)")
        {
            Debug.Log("You Won!");
        }

      

    }


}
