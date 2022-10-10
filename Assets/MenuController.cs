using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string levelToLoad;

    public void LoadLevel()
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void Quit()
    {
        Application.Quit();
    }

}
