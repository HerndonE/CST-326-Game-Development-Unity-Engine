﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CubeDestroyer : MonoBehaviour
{
    public Text scoreText;
    public Text coinText;
    public int points = 0;
    public int coinPoints = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                BoxCollider boxCollider = hit.collider as BoxCollider;
                if(boxCollider.tag != null)
                {
                    Destroy(boxCollider.gameObject);
                    points = points + 100;
                    //scoreText.text = "" + points;
                    scoreText.text = "0000" + points;
                   
                    if (points >= 99)
                    {
                       
                     scoreText.text = "00" + points;
                    }
                }
                if (boxCollider.tag == "qbox")
                {
                    Destroy(boxCollider.gameObject);
                    //Debug.Log("We heed your call");
                    coinPoints = coinPoints + 100;
                    coinText.text = "Coins x " + coinPoints;
                }
                   
            }
        }
    }
}
