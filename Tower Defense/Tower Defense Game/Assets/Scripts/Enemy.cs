using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Enemy : MonoBehaviour, iMovement
{
  public Waypoint currentDestination;
  public WaypointManager waypointManager;
  [SerializeField] private HealthBar healthBar;
  [SerializeField] private float maxLife = 100;
  [SerializeField] private float currentLife = 0;

    public GameObject go;
    public GameObject Explosion;



    public UnityEvent enemyDeath;

  private int currentIndexWaypoint = 0;
  public float speed = 1;

  void Start()
    {
       go = GameObject.Find("PurseManager");
        if (go)
        {
            //Debug.Log(go.name);
        }
        else
        {
            Debug.Log("No game object called PurseManager found");
        }
    }


  public void Initialize(WaypointManager waypointManager)
  {
    currentLife = maxLife;
    healthBar.UpdateHealthBar(currentLife, maxLife);

    this.waypointManager = waypointManager;
    GetNextWaypoint();
    transform.position = currentDestination.transform.position; // Move to WP0
    GetNextWaypoint();

       

    }

  void Update()
  {
    Vector3 direction = currentDestination.transform.position - transform.position;
    if (direction.magnitude < .2f)
    {
      GetNextWaypoint();
    }

    transform.Translate(direction.normalized * speed * Time.deltaTime);
        
  }

  private void GetNextWaypoint()
  {
    if (currentIndexWaypoint < waypointManager.waypoints.Length)
    {
      currentDestination = waypointManager.GetNeWaypoint(currentIndexWaypoint);
      currentIndexWaypoint++;
    }
    
  }


  public GameObject GetGameObject()
  {
    return gameObject;
  }

  void OnCollisionEnter(Collision collision)
  {
    if (collision.transform.tag == "Weapon")
    {
      Bullet bulletThatHitMe = collision.transform.GetComponent<Bullet>();
      currentLife -= bulletThatHitMe.Damage;
      
      healthBar.UpdateHealthBar(currentLife, maxLife);

      if (currentLife <= 0) //We are dead ... need to do book keeping
      {


        go.GetComponent<Purse>().points+=2;
        go.GetComponent<Purse>().coinPoints+=1;
        Instantiate(Explosion, collision.transform.position, collision.transform.rotation);
        enemyDeath.Invoke();
        Destroy(gameObject);

           
       }
      Destroy(bulletThatHitMe.gameObject);
      
    }
  }

  public UnityEvent DeathEvent()
  {
    return enemyDeath;
  }
}
