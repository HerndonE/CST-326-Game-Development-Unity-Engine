using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class BallDestroyPlayerA : MonoBehaviour
{

    public string objectName = "ScoreBoundary1";
    public static float score = 0;        // The player's score.
    public Text text;                 // Reference to the Text component

    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();
        text = GameObject.Find("PlayerBScore").GetComponent<Text>();
        // Reset the score.
        text.text = score.ToString(" ") + score;

    }

    void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == objectName)
        {
            //Destroy(col.gameObject);
            Destroy(gameObject);
            //Debug.Log("Player B won");
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
            text.color = new Color32(255, 230, 230, 200);
        }
        if (score == 3)
        {
            text.color = new Color32(255, 204, 204, 200);
        }
        if (score == 4)
        {
            text.color = new Color32(255, 179, 179, 200);
        }
        if (score == 5)
        {
            text.color = new Color32(255, 153, 153, 200);
        }
        if (score == 6)
        {
            text.color = new Color32(255, 128, 128, 200);
        }
        if (score == 7)
        {
            text.color = new Color32(255, 102, 102, 200);
        }
        if (score == 8)
        {
            text.color = new Color32(255, 77, 77, 200);
        }
        if (score == 9)
        {
            text.color = new Color32(255, 51, 51, 200);
        }
        if (score == 10)
        {
            text.color = new Color32(255, 41, 41, 200);
        }
        if (score == 11)
        {
            text.color = new Color32(255, 0, 0, 200);
        }
    }

}

