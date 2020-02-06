using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BallSpawns
{
    public GameObject ball2, ball3, ball4, ball5, ball6, ball7, ball8, ball9, ball10, ball11;
    public bool spawn2, spawn3, spawn4, spawn5, spawn6, spawn7, spawn8, spawn9, spawn10;
}
public class BallSpawn : MonoBehaviour
{
    public GameObject Startingball;
    public GameObject PlayerA;
    public GameObject PlayerB;
    public bool spawn;
    public BallSpawns ballSpawn;
    public static float score = 0;        // The player's score.
    public Text Wintext;
    public AudioClip otherClip;
    // Start is called before the first frame update


    void Awake()
    {
        Startingball = Instantiate(Startingball, transform.position, transform.rotation);
    }

    void Start()
    {
        Wintext = GetComponent<Text>();
        Wintext = GameObject.Find("Winner!").GetComponent<Text>();
        Wintext.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Startingball == null)
            {
            //Instantiate(ball, new Vector3(0, 2, 0), transform.rotation);
            if (!spawn)
            {
                ballSpawn.ball2 = Instantiate(ballSpawn.ball2, transform.position, transform.rotation);
                Debug.Log("ball spawn2");
                PaddleHit.increaseSpeed = 0f;
                PlayerA.transform.position = new Vector3(9, .32f, 0);
                PlayerB.transform.position = new Vector3(-9, .32f, 0);
                spawn = true;
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip;
                audio.Play();
            }
            }

        if (ballSpawn.ball2 == null)
        {
            if (!ballSpawn.spawn2)
            {
                ballSpawn.ball3 = Instantiate(ballSpawn.ball3, transform.position, transform.rotation);
                Debug.Log("ball spawn3");
                PaddleHit.increaseSpeed = 0f;
                PlayerA.transform.position = new Vector3(9, .32f, 0);
                PlayerB.transform.position = new Vector3(-9, .32f, 0);
                ballSpawn.spawn2 = true;
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip;
                audio.Play();
            }
        }

        if (ballSpawn.ball3 == null)
        {
            if (!ballSpawn.spawn3)
            {
                ballSpawn.ball4 = Instantiate(ballSpawn.ball4, transform.position, transform.rotation);
                Debug.Log("ball spawn4");
                PaddleHit.increaseSpeed = 0f;
                PlayerA.transform.position = new Vector3(9, .32f, 0);
                PlayerB.transform.position = new Vector3(-9, .32f, 0);
                ballSpawn.spawn3 = true;
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip;
                audio.Play();
            }
        }

        if (ballSpawn.ball4 == null)
        {
            if (!ballSpawn.spawn4)
            {
                ballSpawn.ball5 = Instantiate(ballSpawn.ball5, transform.position, transform.rotation);
                Debug.Log("ball spawn5");
                PaddleHit.increaseSpeed = 0f;
                PlayerA.transform.position = new Vector3(9, .32f, 0);
                PlayerB.transform.position = new Vector3(-9, .32f, 0);
                ballSpawn.spawn4 = true;
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip;
                audio.Play();
            }
        }

        if (ballSpawn.ball5 == null)
        {
            if (!ballSpawn.spawn5)
            {
                ballSpawn.ball6 = Instantiate(ballSpawn.ball6, transform.position, transform.rotation);
                Debug.Log("ball spawn6");
                PaddleHit.increaseSpeed = 0f;
                PlayerA.transform.position = new Vector3(9, .32f, 0);
                PlayerB.transform.position = new Vector3(-9, .32f, 0);
                ballSpawn.spawn5 = true;
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip;
                audio.Play();
            }
        }

        if (ballSpawn.ball6 == null)
        {
            if (!ballSpawn.spawn6)
            {
                ballSpawn.ball7 = Instantiate(ballSpawn.ball7, transform.position, transform.rotation);
                Debug.Log("ball spawn7");
                PaddleHit.increaseSpeed = 0f;
                PlayerA.transform.position = new Vector3(9, .32f, 0);
                PlayerB.transform.position = new Vector3(-9, .32f, 0);
                ballSpawn.spawn6 = true;
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip;
                audio.Play();
            }
        }

        if (ballSpawn.ball7 == null)
        {
            if (!ballSpawn.spawn7)
            {
                ballSpawn.ball8 = Instantiate(ballSpawn.ball8, transform.position, transform.rotation);
                Debug.Log("ball spawn8");
                PaddleHit.increaseSpeed = 0f;
                PlayerA.transform.position = new Vector3(9, .32f, 0);
                PlayerB.transform.position = new Vector3(-9, .32f, 0);
                ballSpawn.spawn7 = true;
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip;
                audio.Play();
            }
        }

        if (ballSpawn.ball8 == null)
        {
            if (!ballSpawn.spawn8)
            {
                ballSpawn.ball9 = Instantiate(ballSpawn.ball9, transform.position, transform.rotation);
                Debug.Log("ball spawn9");
                PaddleHit.increaseSpeed = 0f;
                PlayerA.transform.position = new Vector3(9, .32f, 0);
                PlayerB.transform.position = new Vector3(-9, .32f, 0);
                ballSpawn.spawn8 = true;
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip;
                audio.Play();
            }
        }

        if (ballSpawn.ball9 == null)
        {
            if (!ballSpawn.spawn9)
            {
                ballSpawn.ball10 = Instantiate(ballSpawn.ball10, transform.position, transform.rotation);
                Debug.Log("ball spawn10");
                PaddleHit.increaseSpeed = 0f;
                PlayerA.transform.position = new Vector3(9, .32f, 0);
                PlayerB.transform.position = new Vector3(-9, .32f, 0);
                ballSpawn.spawn9 = true;
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip;
                audio.Play();
            }
        }

        if (ballSpawn.ball10 == null)
        {
            if (!ballSpawn.spawn10)
            {
                ballSpawn.ball11 = Instantiate(ballSpawn.ball11, transform.position, transform.rotation);
                Debug.Log("ball spawn11");
                PaddleHit.increaseSpeed = 0f;
                PlayerA.transform.position = new Vector3(9, .32f, 0);
                PlayerB.transform.position = new Vector3(-9, .32f, 0);
                ballSpawn.spawn10 = true;
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = otherClip;
                audio.Play();
            }
        }

        if(ballSpawn.ball11 == null)
        {
            Wintext.gameObject.SetActive(true);
 
            if (BallDestroyPlayerA.score > BallDestroyPlayerB.score)
            {
                Wintext.text = score.ToString("Player B Won");
                Debug.Log("Player B Won");
            }
                else
                Wintext.text = score.ToString("Player A Won");
                Debug.Log("Player A Won");
    
            if (BallDestroyPlayerB.score == BallDestroyPlayerA.score)
            {
                Wintext.text = score.ToString("Tie");
                Debug.Log("Tie!");
            }
            return;
        }


    }
}
