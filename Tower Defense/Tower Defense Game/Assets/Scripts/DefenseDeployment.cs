using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseDeployment : MonoBehaviour
{
    public Color hoverColor;
    private GameObject turret;
    public Color startColor;
    public Vector3 positionOffset;
    private Renderer rend;
    private GameObject thisObject;
    Purse thyEnemyHealth;
   
    void Start()
    {
        
       rend = GetComponent<Renderer>();
       thyEnemyHealth = GameObject.Find("PurseManager").GetComponent<Purse>();
    }

    void OnMouseDown()
    {
        //Debug.Log(thyEnemyHealth.cointPoints); //This works! TODO: Conditions points to place defenses

        if (thyEnemyHealth.coinPoints >= 6)
        {

            if (turret != null)
            {
                Debug.Log("You cannot build there!");
                return;
            }

            GameObject turretToBuild = BuildManager.instance.getTurretToBuild();
            turret = Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation * Quaternion.Euler(-90f, 0f, 0f));

            thyEnemyHealth.GetComponent<Purse>().coinPoints = thyEnemyHealth.GetComponent<Purse>().coinPoints - 6;

            Debug.Log(thyEnemyHealth.coinPoints);

        }

        Debug.Log("You need more kills!");

    }

    void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

     void OnMouseExit()
    {
        rend.material.color = startColor;
    }

}
