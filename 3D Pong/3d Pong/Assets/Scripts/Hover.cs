using UnityEngine;
using System.Collections;


public class Hover : MonoBehaviour
{
    public float speed;
    public bool PlayerA;
    public bool PlayerB;
    void Update()
    {
        if (PlayerA)
        {
            transform.Translate(0f, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f); //playerA W and S
        }
        if (PlayerB)
        {
            transform.Translate(0f, Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f); //PlayerB J and L
        }

    }
}




