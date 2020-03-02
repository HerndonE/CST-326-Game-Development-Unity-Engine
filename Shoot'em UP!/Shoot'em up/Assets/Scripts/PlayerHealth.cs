using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public GameObject[] spawn;
    //public Spawner spawner;
    public string objectName;
    public string bulletName;
    public Text text;
    public Image healthbar;
    public int maxHealth = 100;
    public Text YouLost;
    public bool takeDamage;
    public float delay = 1.0f;
   

    void Awake()
    {
        // Set up the reference.
        takeDamage = true;
        text = GetComponent<Text>();
        text = GameObject.Find("HealthCounter").GetComponent<Text>();
        text.text = maxHealth.ToString("Health: ") + maxHealth;
        text.color = Color.white;

        YouLost = GetComponent<Text>();
        YouLost = GameObject.Find("LoseCounter").GetComponent<Text>();

        healthbar = GameObject.Find("HealthBar").GetComponent<Image>();
        healthbar.color = Color.green;

    }

    void OnTriggerEnter(Collider col)
    {  
        if (col.gameObject.tag == objectName || col.gameObject.tag == bulletName && maxHealth > 0f)
            if (takeDamage == true)
                {
                    maxHealth -= 10;
                    healthbar.fillAmount -= .1f;
                    text.text = maxHealth.ToString("Health: ") + maxHealth;
                    // Destroy(col.gameObject);
                        if (maxHealth == 50)
                        {
                        //text.color = Color.yellow;
                        healthbar.color = Color.yellow;
                        }

                        if (maxHealth == 20)
                        {
                         //text.color = Color.red;
                         healthbar.color = Color.red;
                        }

                        if (maxHealth == 0)//problem
                        {
                        //Destroy(col.gameObject);
                        gameObject.SetActive(false); //works
                    //Destroy(gameObject); //Even better
                    //YouLost.text = "You Lost!";
                    takeDamage = false;
                                foreach (GameObject _obj in spawn)
                                {
                                     _obj.SetActive(false);
                                    //Destroy(_obj);
                                    _obj.GetComponent<Spawner>().enabled = false;
                                    //Later want to fix this, eventually have .SetActive to false and call the
                                    //GameObjects[] enemies and set them to zero!
                                }
                 

                      
                    
                }
         
    }
       

    }
    
}
