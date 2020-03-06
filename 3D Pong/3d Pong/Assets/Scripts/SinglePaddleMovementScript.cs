using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinglePaddleMovementScript : MonoBehaviour
{
    public float speed;
    public GameObject player1;
    public GameObject player2;
    public float minY = -3; 
    public float maxY = 5; 

    void Update()
    {
        if (player1.transform.position.y <= minY || player1.transform.position.y >= maxY)
        {
            float yPos = Mathf.Clamp(player1.transform.position.y, minY, maxY);
            player1.transform.position = new Vector3(player1.transform.position.x, yPos, 0);
        }

        if (player2.transform.position.y <= minY || player2.transform.position.y >= maxY)
        {
            float yPos = Mathf.Clamp(player2.transform.position.y, minY, maxY);
            player2.transform.position = new Vector3(player2.transform.position.x, yPos, 0);
        }

        player1.transform.Translate(0f, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f); //playerA W and S
       
        player2.transform.Translate(0f, Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f); //PlayerB J and L
 
    }
}
