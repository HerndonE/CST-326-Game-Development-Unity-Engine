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

        changeColor();

    }

    void changeColor()
    {
        if (score == 1)
        {
            text.color = new Color32(255, 255, 255, 200);
        }
        if (score == 2)
        {
            text.color = new Color32(230, 243, 255, 200);
        }
        if (score == 3)
        {
            text.color = new Color32(204, 230, 255, 200);
        }
        if (score == 4)
        {
            text.color = new Color32(153, 206, 255, 200);
        }
        if (score == 5)
        {
            text.color = new Color32(128, 193, 255, 200);
        }
        if (score == 6)
        {
            text.color = new Color32(102, 181, 255, 200);
        }
        if (score == 7)
        {
            text.color = new Color32(77, 169, 255, 200);
        }
        if (score == 8)
        {
            text.color = new Color32(51, 156, 255, 200);
        }
        if (score == 9)
        {
            text.color = new Color32(26, 144, 255, 200);
        }
        if (score == 10)
        {
            text.color = new Color32(0, 132, 255, 200);
        }
        if (score == 11)
        {
            text.color = new Color32(0, 119, 255, 200);
        }
    }

}
