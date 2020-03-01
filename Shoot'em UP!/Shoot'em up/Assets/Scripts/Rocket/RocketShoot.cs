using UnityEngine;
using System.Collections;

public class RocketShoot : MonoBehaviour {

    public Transform target; //Enemy

    //public GameObject[] enemies;

    public int moveSpeed;
    public int rotationSpeed;
    public float maxdistance;
    //public GameObject[] shootPoints;

    private Transform myRocket;

    void Awake()
    {
        if (target == null)
        {
            target = GameObject.FindWithTag("enemy").transform;

            myRocket = transform;
            myRocket.LookAt(target);
        }
        //target = GameObject.FindWithTag("enemy").transform;
        //GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
        //myRocket = transform;
        //myRocket.LookAt(target);
    }

    void Start()
    {
        
    }

    void Update()
    {
        myRocket.LookAt(target);
        myRocket = transform;

        if (Vector3.Distance(target.position, myRocket.position) > maxdistance)
        {

            // Get a direction vector from us to the target
            Vector3 dir = target.position - myRocket.position;

            // Normalize it so that it's a unit direction vector
            dir.Normalize();

            // Move ourselves in that direction
            myRocket.position += dir * moveSpeed * Time.deltaTime;

        }

        if (Vector3.Distance(target.position, myRocket.position) < maxdistance)
        {
           
        }

    }
}
