using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}


public class Hover : MonoBehaviour
{
    public float speed;
    public float tilt;
    public Boundary boundary;
    public Rigidbody rb;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;

        transform.position = new Vector3
        (
            Mathf.Clamp(transform.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(transform.position.z, boundary.zMin, boundary.zMax)
        );

        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }

    /*
        public float speed = 3f;
        public Boundary boundary;
        void Update()
        {

            if (Input.GetKey ("a")) {
                transform.Translate (Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey("d"))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);

            }

        }

        /*
        */
}

