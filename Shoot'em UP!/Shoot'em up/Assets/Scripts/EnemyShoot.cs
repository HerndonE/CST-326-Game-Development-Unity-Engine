using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {


    public GameObject prefab;
    public float delay = 0.0f;
    public bool Shoot = false;
    public Animator playerAnimator;
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        
        if (Shoot == false)
        {
            StartCoroutine(Build(delay));
            Shoot = true;
            playerAnimator.SetTrigger("shootE");
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
