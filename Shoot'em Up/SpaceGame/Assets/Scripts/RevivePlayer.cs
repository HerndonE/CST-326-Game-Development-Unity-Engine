using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class RevivePlayer : MonoBehaviour {

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;

    public Image player1Image;
    public Image player2Image;
    public Image player3Image;

    // public Text P1;
    public Image playerHealth;
    public float delay = 0f ;
    // Use this for initialization
    public bool created1 = false;
    public bool created2 = false;
   // public bool created3 = false;

    private int currentLife = 3;

    
    public bool isExploded = false;
    public GameObject explosion1;
    public GameObject explosion2;
    public GameObject explosion3;

    void Start()
    {


        transform.position = new Vector3(5.0f, 0.0f, 0.0f);

        Debug.Log("Player 1 alive");
        //player2.SetActive(false);
        player1 = Instantiate(player1, transform.position, transform.rotation);
    }


    IEnumerator Build(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (!created1)
        {
            player2=Instantiate(player2, transform.position, transform.rotation);
            playerHealth.fillAmount = 1;
            created1 = true;
            isExploded = true;
        }
    }
    IEnumerator Build2(float delay)
    {
        yield return new WaitForSeconds(delay);
        if (!created2)
        {
            player3 = Instantiate(player3, transform.position, transform.rotation);
            playerHealth.fillAmount = 1;
            created2 = true;
            isExploded = false;
        }
    }


    void Update()
    {

        if (player1.activeSelf == false && currentLife == 3)
        {
            if (isExploded == false)
            {
                explosion1 = Instantiate(explosion1, player1.transform.position, transform.rotation);
                
            }

            currentLife = currentLife - 1;
            player1Image.enabled = false;
            Debug.Log(currentLife);
            StartCoroutine(Build(delay));

           
        }

        if (player2.activeSelf == false && currentLife == 2)
        {
            if (isExploded == true)
            {
                explosion2 = Instantiate(explosion2, player2.transform.position, transform.rotation);

            }

            currentLife = currentLife - 1;
            player2Image.enabled = false;
            Debug.Log(currentLife);
            StartCoroutine(Build2(delay));          
        }

        if (player3.activeSelf == false && currentLife == 1)
        {
            if (isExploded == false)
            {
                explosion3 = Instantiate(explosion3, player3.transform.position, transform.rotation);

            }


            Debug.Log("Game Over");
            currentLife = currentLife - 1;
            player3Image.enabled = false;
            Debug.Log(currentLife);
            //StartCoroutine(Build2(delay));
        }
        // Debug.Log(player1.activeSelf);
        //  Debug.Log(player2.activeSelf);

    }
    
}
