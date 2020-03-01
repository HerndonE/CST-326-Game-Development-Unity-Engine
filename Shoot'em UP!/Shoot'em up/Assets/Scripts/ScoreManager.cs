using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {
    public static float score ;        // The player's score.
    public Text text;                      // Reference to the Text component
    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();
        text =  GameObject.Find("ScoreCounter").GetComponent<Text>();
        // Reset the score.
        score = 0;
    }


    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        //text.text = "Score: " + score ;
        //AddScore.ScoreCount += score;
        //score += Time.deltaTime;
        text.text = score.ToString("Score: ") + score;
    }

}
