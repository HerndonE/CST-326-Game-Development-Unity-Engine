using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {


    public GameObject prefab;
    public float delay = 0.0f;
   public bool Shoot = false;
    void Update()
    {
        if (Shoot == false)
        {
            StartCoroutine(Build(delay));
            Shoot = true;
        }
    }
    IEnumerator Build(float delay)
    {
        yield return new WaitForSeconds(delay);
        GameObject newCrate = GameObject.Instantiate(prefab, transform.position, transform.rotation) as GameObject;
        Shoot = false;
        //Debug.Log("shoot");
    }
}
