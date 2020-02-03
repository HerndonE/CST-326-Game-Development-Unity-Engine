using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEffects : MonoBehaviour
{

    [SerializeField] [Range(0, 1000)] private float amplify = 1;
    public ForceMode forceMode;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
        if (collision.gameObject.tag == "ball")
        {
            rb.AddForce(Vector3.up * amplify, forceMode);
        }

        if (collision.gameObject.tag == "TeamB")
        {
            Vector3 launchAngle = new Vector3(1,1,0) * amplify;
            rb.AddForce(launchAngle, forceMode);
        }

        //Debug.Log(collision.gameObject.name + " hit me");
    }

    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log(collision.gameObject.name + " is touching me");
    }

    private void OnCollisionExit(Collision collision)
    {
        //Debug.Log(collision.gameObject.name + " left me");
    }
}
