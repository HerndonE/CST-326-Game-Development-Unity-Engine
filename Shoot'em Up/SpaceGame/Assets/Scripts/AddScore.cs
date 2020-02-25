using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AddScore : MonoBehaviour {
   
    public int ScoreCount = 10;
    public bool isExploded = true;
    public GameObject explosion;
    void OnDestroy () {
            //Debug.Log("Not Alive");

        ScoreManager.score += ScoreCount;
        if (isExploded == true)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            isExploded = false;
        }
    }
}
