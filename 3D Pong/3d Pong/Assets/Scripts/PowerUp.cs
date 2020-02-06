using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject paddlePlayer;
    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "BigPaddle")
        {
            Debug.Log("Hit");
            paddlePlayer.transform.localScale += new Vector3(0, 4, 0);
        }
        if (col.gameObject.tag == "SmallPaddle")
        {
            Debug.Log("Hit");
            paddlePlayer.transform.localScale -= new Vector3(0, 1, 0);
        }

    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
