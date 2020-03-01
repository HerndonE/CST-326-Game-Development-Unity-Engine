using UnityEngine;

using System.Collections;


public class EnemyDestroy : MonoBehaviour
{

    public string objectName;

     void OnTriggerEnter(Collider col)
    {
        
        if (col.gameObject.tag == objectName)
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
      
    }

}

