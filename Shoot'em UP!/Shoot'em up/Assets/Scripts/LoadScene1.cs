using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScene1 : MonoBehaviour
{

    public int levelNumber = 0;
    public int levelNumber2 = 0;
    public int levelNumber3 = 0;
    public int levelNumber4 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(levelNumber);
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene(levelNumber2);
        Time.timeScale = 1;
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene(levelNumber3);
        Time.timeScale = 1;
    }

    public void LoadScene4()
    {
        SceneManager.LoadScene(levelNumber4);
        Time.timeScale = 0;
    }

}
