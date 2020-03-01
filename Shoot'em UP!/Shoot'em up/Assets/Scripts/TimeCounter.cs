using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeCounter : MonoBehaviour {

    public GameObject[] spawn;
    public string enemy;
    public Text text;
    public Text YouWin;
    public float timerInSeconds = 0f;
    public bool timeStarted = true;

    private GameObject[] prefabsInScene;
    public GameObject[] playersClub;
    public GameObject camera;
    public GameObject lifeManager;
    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
        text = GameObject.Find("TimeCounter").GetComponent<Text>();

        YouWin = GetComponent<Text>();
        YouWin = GameObject.Find("WinCounter").GetComponent<Text>();

     
    }

    // Update is called once per frame
    void Update () {
        //GameObject[] prefabsInScene = GameObject.FindGameObjectsWithTag("enemy");
        prefabsInScene = GameObject.FindGameObjectsWithTag("enemy");
        playersClub = GameObject.FindGameObjectsWithTag("Player");
        //Debug.Log(prefabsInScene);
        if (timeStarted == true)
        {

            timerInSeconds -= Time.deltaTime;

            int minutes = Mathf.FloorToInt(timerInSeconds / 60F);
            int seconds = Mathf.FloorToInt(timerInSeconds - minutes * 60);
            text.text = string.Format("{0:0}:{1:00}", minutes, seconds);

            if (minutes ==  0 && seconds == 0)
            {
                timeStarted = false;
                timerInSeconds = 0;
                YouWin.text = "You Win!";
                //Time.timeScale = 0; //stops all time 
                //GameObject[] prefabsInScene = GameObject.FindGameObjectsWithTag("enemy");
              
                foreach (GameObject player in playersClub)
                {
                    player.SetActive(false);
                    lifeManager.SetActive(false);
                    camera.GetComponent<pauseGame>().enabled = false;
                }

                foreach (GameObject target in prefabsInScene)
                {
                    GameObject.Destroy(target);
                }

                foreach (GameObject _obj in spawn)
                {
                    // _obj.SetActive(false);
                    Destroy(_obj);
                    _obj.GetComponent<Spawner>().enabled = false;
                   
                    //Later want to fix this, eventually have .SetActive to false and call the
                    //GameObjects[] enemies and set them to zero!
                }

             

            }
      } 
    }
  
}
