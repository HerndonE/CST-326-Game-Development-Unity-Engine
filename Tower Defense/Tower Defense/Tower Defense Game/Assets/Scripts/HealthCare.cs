using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthCare : MonoBehaviour
{
    public int health = 0;
    public Text scoreText;
    public Text coinText;
    public int points = 0;
    public int cointPoints = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        coinText = GameObject.Find("Coin").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        takeScore();
    }

    void takeScore()
    {
        if (health == 0)
        {
            health++;
            Destroy(gameObject);
           
           

        }
    }

}
