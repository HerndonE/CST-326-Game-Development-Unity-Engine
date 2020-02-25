using UnityEngine;
using System.Collections;

public class AsteroidMovement : MonoBehaviour {

    public int xSpeed = 0;
    public int ySpeed = 0;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(Vector3.up * Time.deltaTime * xSpeed);
        transform.Rotate(Vector3.right * Time.deltaTime * ySpeed);

    }
}
