using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset;
    private GameObject player;

    void Start()
    {
        //offset = transform.position;
    }

    void LateUpdate()
    {
        if (player == null)
        {
            player = GameObject.Find("Ethan");
        }
        else
        {
            transform.position = player.transform.position + offset;
        }
    }
}
