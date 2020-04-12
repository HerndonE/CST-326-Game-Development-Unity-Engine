using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Purse : MonoBehaviour
{

    public Text scoreText;
    public Text coinText;
    public float points = 0;
    public float coinPoints = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        coinText = GameObject.Find("Coin").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePurse();
    }

    public void UpdatePurse()
    {
        //points++;
        scoreText.text = "Score:" + points;
        //coinPoints++;
        coinText.text = "Coins:" + coinPoints;
    }
}
