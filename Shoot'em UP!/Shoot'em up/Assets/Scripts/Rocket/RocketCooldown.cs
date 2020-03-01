using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RocketCooldown : MonoBehaviour {

    public Text text;
    public Image rocketCooldown;
    public float rocketReadyInSeconds = 30.0f;
    public bool timeStarted = true;
    public GameObject prefab;

    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
        text = GameObject.Find("RocketCounter").GetComponent<Text>();
        rocketCooldown = GetComponent<Image>();
        rocketCooldown = GameObject.Find("RocketCooldown").GetComponent<Image>();
        text.color = Color.white;
   
    }

    // Update is called once per frame
    void Update() {
       
        if (timeStarted)
        {
            rocketReadyInSeconds -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(rocketReadyInSeconds / 60F);
            int seconds = Mathf.FloorToInt(rocketReadyInSeconds - minutes * 60);
            text.text = string.Format("Rocket Ready: " + seconds);
            rocketCooldown.fillAmount -= 1.0f / (seconds + 16) * Time.deltaTime;
            if (seconds == 0)
            {
                text.text = string.Format("Rkt Ready: GO!");
                timeStarted = false;           
                Debug.Log("depleted");
            }
           
            else if (seconds == 0)
            {
                //rocketGo.GetComponent<ShootRocket>().enabled = true;
            }
   
        }

        if (timeStarted == false& Input.GetMouseButtonDown(1))
        {
            GameObject newCrate = GameObject.Instantiate(prefab, transform.position, transform.rotation) as GameObject;
            Debug.Log("Time Was Reset");
            timeStarted = true;         
            rocketCooldown.fillAmount = 1.0f;
            rocketReadyInSeconds = 30.0f;
            text.text = string.Format("Rkt Ready: " + rocketReadyInSeconds);

        }

    }



}

