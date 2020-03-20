using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Text scoreText;
    public Text coinText;
    public string tagName;
    public int points = 0;
    public int cointPoints = 0;
    public int enemyHealth;
    RaycastHit hit;
    void Start()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        coinText = GameObject.Find("Coin").GetComponent<Text>();
       
    }

        
        // Update is called once per frame
        void Update()
        {
       
        if (Input.GetMouseButtonDown(0))
            {
               
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit))
                {
                    BoxCollider boxCollider = hit.collider as BoxCollider;
                
                    if (boxCollider.gameObject.name == "Cube")
                    {
                       //Destroy(boxCollider.gameObject);
                        Debug.Log("We heed your call");
                    boxCollider.gameObject.GetComponent<HealthCare>().health--;

                    if (boxCollider.gameObject.GetComponent<HealthCare>().health > 0)
                    {
                        points++;
                        scoreText.text = "Score:" + points;

                        cointPoints++;
                        coinText.text = "Coins:" + cointPoints;
                    }
                    
                 
                   
                }

                   

                }
            }

        }


    }
