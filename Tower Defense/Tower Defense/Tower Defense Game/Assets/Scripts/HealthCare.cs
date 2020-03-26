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

    public int startHealth = 100;
    
    public float FillAmount;

    [Header("Unity Stuff")]
    public Image Bar;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        coinText = GameObject.Find("Coin").GetComponent<Text>();
        Bar.fillAmount = 1.0f;
        //startHealth = health;
       
    }

    // Update is called once per frame
    void Update()
    {
        takeScore();
        Bar.fillAmount = 1.0f / health;
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
