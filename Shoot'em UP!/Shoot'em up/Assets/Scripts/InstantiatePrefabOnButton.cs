using UnityEngine;
using System.Collections;

public class InstantiatePrefabOnButton : MonoBehaviour {

	public GameObject prefab;
	public string buttonName = "Fire1";
    public Animator playerAnimator;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
       
        if (Input.GetButtonDown(buttonName))
        {
            playerAnimator.SetTrigger("shootP");
            GameObject newCrate = GameObject.Instantiate(prefab, transform.position, transform.rotation) as GameObject;
        }
        }	
}



