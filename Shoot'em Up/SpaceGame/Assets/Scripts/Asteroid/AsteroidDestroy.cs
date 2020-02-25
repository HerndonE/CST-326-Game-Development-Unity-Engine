using UnityEngine;
using System.Collections;

public class AsteroidDestroy : MonoBehaviour {

    public string objectName = "asteroids";
    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == objectName)
        {
            Destroy(col.gameObject);

        }

    }
}
