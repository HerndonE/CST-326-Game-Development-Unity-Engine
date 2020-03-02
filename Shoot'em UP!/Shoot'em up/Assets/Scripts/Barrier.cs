using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    // Start is called before the first frame update

    public int barrierHealth = 20;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        barrierHealth -= 1;
        //Debug.Log(barrierHealth);
        if (barrierHealth == 0)
        {
            Destroy(gameObject);
        }

        if (col.gameObject.tag == "enemy")
        {
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "bullet")
        {
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "enemybullet")
        {
            Destroy(col.gameObject);
        }


    }
}
