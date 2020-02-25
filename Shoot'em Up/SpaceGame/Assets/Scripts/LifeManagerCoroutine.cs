using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class LifeManagerCoroutine : MonoBehaviour {

    public GameObject currentprefab;
    public GameObject prefab2;
    public GameObject prefab3;
    //public GameObject[] players;
    public float delay = 1.0f;
    public Image lifeOne;
    public Image lifeTwo;
    public Image lifeThree;
    public GameObject[] spawn;

    void Start()
    {
      
    }
    void Update()
    {

        if (currentprefab.active == false)
        {
            lifeOne.enabled = false;
            StartCoroutine(Build1(delay));
            foreach (GameObject _obj in spawn)
            {
                _obj.SetActive(true);
                _obj.GetComponent<Spawner>().enabled = true;
            }
       
        }
       //if (currentprefab.active == false)
            if (prefab2.active == false)
            {
                lifeTwo.enabled = false;
                //StartCoroutine(Build1(delay));
                StartCoroutine(Build2(delay));

                foreach (GameObject _obj in spawn)
                {
                    _obj.SetActive(true);
                    _obj.GetComponent<Spawner>().enabled = true;
                }
            }
    }

    IEnumerator Build1(float delay)
    {
        yield return new WaitForSeconds(delay);
        //Instantiate(prefab2, new Vector3(0, 1, -24), transform.rotation);
        //ph.gameObject.SetActive(true);
        prefab2.SetActive(true);

        //Instantiate(pieces[Random.Range(0, pieces.Length)],
       

    }

    IEnumerator Build2(float delay)
    {
        yield return new WaitForSeconds(delay);
        

    }

}
