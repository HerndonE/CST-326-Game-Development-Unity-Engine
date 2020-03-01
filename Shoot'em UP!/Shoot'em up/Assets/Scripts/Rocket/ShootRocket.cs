using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShootRocket : MonoBehaviour {

    public GameObject prefab;

    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            GameObject newCrate = GameObject.Instantiate(prefab, transform.position, transform.rotation) as GameObject;
            
        }
        
           
          
       
            
    }
}
