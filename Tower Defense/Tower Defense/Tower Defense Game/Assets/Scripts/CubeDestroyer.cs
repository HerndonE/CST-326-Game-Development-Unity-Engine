using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CubeDestroyer : MonoBehaviour
{
    public Text scoreText;
    public Text coinText;
    public int points = 0;
    public int cointPoints = 0;
    public int enemyAHealth;
    public int enemyBHealth;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
           

            if(Physics.Raycast(ray, out hit))
            {
                BoxCollider boxCollider = hit.collider as BoxCollider;
                if(boxCollider.tag != null)
                {
                    enemyAHealth--;
                    Debug.Log(enemyAHealth);
                    if (enemyAHealth < 0)
                    {
                        Destroy(boxCollider.gameObject);
                        points = points + 10;
                        scoreText.text = "Score:" + points;

                        cointPoints = cointPoints + 1;
                        coinText.text = "Coins:" + cointPoints;
                    }
                }
                if (hit.collider.tag == "enemyB")
                {
                    enemyBHealth--;
                    Debug.Log(enemyBHealth);
                    if (enemyBHealth == 0)
                    {
                        Destroy(boxCollider.gameObject);
                        points = points + 10;
                        scoreText.text = "Score:" + points;

                        cointPoints = cointPoints + 2;
                        coinText.text = "Coins:" + cointPoints;

                    }
                }
                   
            }
        }
    }
}
