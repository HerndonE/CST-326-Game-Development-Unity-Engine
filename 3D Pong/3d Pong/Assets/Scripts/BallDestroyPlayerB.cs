using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BallDestroyPlayerB : MonoBehaviour
{
    public string objectName = "ScoreBoundary";
    public static float score = 0;        // The player's score.
    public Text text;                 // Reference to the Text component
    
    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();
        text = GameObject.Find("PlayerAScore").GetComponent<Text>();
        // Reset the score.
        text.text = score.ToString(" ") + score;

    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == objectName)
        {
            //Destroy(col.gameObject);
            Destroy(gameObject);
            //Debug.Log("Player A won");
            score = score + 1;
            text.text = score.ToString(" ") + score;


        }

    }
}
