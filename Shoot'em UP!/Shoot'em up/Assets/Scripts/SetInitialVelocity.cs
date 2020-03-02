using UnityEngine;
using System.Collections;

public class SetInitialVelocity : MonoBehaviour {
	public float forwardSpeed = 10.0f;
	public float upSpeed = 10.0f;
    public AudioClip otherClip;
    // Use this for initialization
    void Start () {
		GetComponent<Rigidbody> ().velocity = forwardSpeed * transform.forward + upSpeed * transform.up;
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = otherClip;
        audio.Play();
    }
}
