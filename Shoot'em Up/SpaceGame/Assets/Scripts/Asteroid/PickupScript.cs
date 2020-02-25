using UnityEngine;
using System.Collections;

public class PickupScript : MonoBehaviour {

   
    public string special = "Special";
    public GameObject objectShoot;
    public GameObject spreaderShootHolder;

    void OnCollisionEnter(Collision col)//////////////// maybe on asteroid?
    {
        objectShoot.SetActive(false);
        spreaderShootHolder.SetActive(true);
        //gameObject.GetComponent<InstantiatePrefabOnButton>().enabled = false;
        Debug.Log("pickedup");
        if (col.gameObject.tag == special)
        {
            Destroy(col.gameObject);
        }

    }
}
