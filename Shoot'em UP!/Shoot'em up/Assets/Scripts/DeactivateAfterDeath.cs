using UnityEngine;
using System.Collections;

public class DeactivateAfterDeath : MonoBehaviour {

    PlayerHealth health;
    public GameObject[] spawnPt;
	// Use this for initialization
	void FixedUpdate() {
        health = GetComponent<PlayerHealth>();
        if (health.maxHealth == 0)
        {
            foreach (GameObject _obj in spawnPt)
            {

                _obj.SetActive(false);

            }
        }
	
	
	
      
           
        

	}
}
