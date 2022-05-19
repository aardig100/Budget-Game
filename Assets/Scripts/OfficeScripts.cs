using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OfficeScripts : MonoBehaviour
{
    public string cityScene;
    public void Door()
    {
        SceneManager.LoadScene(cityScene);
    }

}
