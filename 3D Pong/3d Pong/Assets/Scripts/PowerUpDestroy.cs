using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpDestroy : MonoBehaviour
{

    public string objectName = "ScoreBoundary";
    public string objectName1 = "ScoreBoundary1";
    public string objectName2 = "player";
    public AudioClip otherClip;
    private void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == objectName)
        {
            //Destroy(col.gameObject);
            Destroy(gameObject);
            gameObject.GetComponent<DestroyAfterDelay>().enabled = true;
        }

        if (col.gameObject.tag == objectName1)
        {
            //Destroy(col.gameObject);
            Destroy(gameObject);
            gameObject.GetComponent<DestroyAfterDelay>().enabled = true;
        }

        if (col.gameObject.tag == objectName2)
        {
            //Destroy(col.gameObject);
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = otherClip;
            audio.Play();
            gameObject.GetComponent<DestroyAfterDelay>().enabled = true;
        }
      

    }



    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<DestroyAfterDelay>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
