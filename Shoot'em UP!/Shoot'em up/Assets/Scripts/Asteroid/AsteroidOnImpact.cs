using UnityEngine;
using System.Collections;

public class AsteroidOnImpact : MonoBehaviour {

    public string objectName = "Player" ;
    public GameObject[] miniAsteroids;
    //public GameObject miniAsteroids;

    void Awake()
    {

        foreach (GameObject asteroid in miniAsteroids)
        {
            asteroid.SetActive(false);
        }
    }


    void OnTriggerEnter(Collider col)
    {
        foreach (GameObject asteroid in miniAsteroids)
        {
            asteroid.SetActive(true);
        }
        if (col.gameObject.tag == objectName)
        {
            
            Destroy(col.gameObject);
          
        }

    }
}
