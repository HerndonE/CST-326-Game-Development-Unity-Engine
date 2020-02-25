using UnityEngine;
using System.Collections;

//internet


public class Ship101 : MonoBehaviour {

	public Transform target; //Player
	public int moveSpeed;
	public int rotationSpeed;
    public float maxdistance;
    public GameObject[] shootPoints;

    private Transform myTransform;


    public GameObject TheTarget;

	void Awake()
	{
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        myTransform = transform;
        myTransform.LookAt(target);//fix to tag!

        // myTransform.Find("Player");//fix to tag!

    }

    void Start ()
	{
        foreach (GameObject obj in shootPoints)
        {
            obj.SetActive(false);
        }
    }

    void Update()
    {
        myTransform.LookAt(target);
        myTransform = transform;
        if (Vector3.Distance(target.position, myTransform.position) > maxdistance)
        {

            // Get a direction vector from us to the target
            Vector3 dir = target.position - myTransform.position;

            // Normalize it so that it's a unit direction vector
            dir.Normalize();

            // Move ourselves in that direction
            myTransform.position += dir * moveSpeed * Time.deltaTime;

        }

        if (Vector3.Distance(target.position, myTransform.position) < maxdistance)
        {
            foreach (GameObject obj in shootPoints)
            {
                obj.SetActive(true);
            }
        }

        if (TheTarget.activeSelf == false)
        {
            Destroy(myTransform) ;
        }
    }
}