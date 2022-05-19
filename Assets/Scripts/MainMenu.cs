using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string officeScene;

    public void NewGame()
    {
        SceneManager.LoadScene(officeScene);
    }

    public void LoadGame()
    {

    }

    public void OpenSettings()
    {

    }

    public void CloseSettings()
    {

    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
}

