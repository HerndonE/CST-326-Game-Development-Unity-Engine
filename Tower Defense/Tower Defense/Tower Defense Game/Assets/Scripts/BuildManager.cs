using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{

    public static BuildManager instance;

    void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More than 1!");
            return;
        }

        instance = this; 
    }

    public GameObject standandTurret;

    private void Start()
    {
        turretToBuild = standandTurret;
    }

    private GameObject turretToBuild;

    public GameObject getTurretToBuild()
    {
        return turretToBuild;
    }

}
