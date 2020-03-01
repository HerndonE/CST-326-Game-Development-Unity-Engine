using UnityEngine;
using System.Collections;

[System.Serializable]
public class Limit
{
    public float xMin, xMax, zMin, zMax;
}


public class SpawnAsteroid : MonoBehaviour {

    public Limit boundary;
    //public GameObject prefab;
    public float spawnTime = 5f;        // The amount of time between each spawn.
    public float spawnDelay = 3f;       // The amount of time before spawning starts.

    void Start()
    {
        InvokeRepeating("Spawn", spawnDelay, spawnTime);
    }
    /*
    void Spawn()
    {
        Vector3 position = new Vector3(Random.Range(boundary.xMin, boundary.xMax), 0, Random.Range(boundary.zMin, boundary.zMax));
        Instantiate(prefab, position, Quaternion.identity);
        Debug.Log("Asteroid Spawned");
    }
    */
    public GameObject[] enemies;        // Array of enemy prefabs.

   

    void Spawn()
    {
        // Instantiate a random enemy.
        int enemyIndex = Random.Range(0, enemies.Length);
        Vector3 position = new Vector3(Random.Range(boundary.xMin, boundary.xMax), 0, Random.Range(boundary.zMin, boundary.zMax));
        Instantiate(enemies[enemyIndex], position, Quaternion.identity);
       
        //Instantiate(enemies[enemyIndex], transform.position, transform.rotation);
    }
    //to be continued


}
