using UnityEngine;
using System.Collections;

public class DeathOnImpact : MonoBehaviour {

    public string objectName = "Player";
   // public GameObject explosion;
   // public bool isExploded = true;
    
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == objectName)// && isExploded == true)
        {
            Destroy(gameObject);
            // Instantiate(explosion);
           
                //Instantiate(explosion, transform.position, transform.rotation);
            //isExploded = false;
            

            //Debug.Log("Explosion");
            //Debug.Log("EnemyDeath");
        }
        

    }
}
