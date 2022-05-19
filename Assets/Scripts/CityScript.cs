using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CityScript : MonoBehaviour
{
    public string officeScene;
    public void ReturnOffice()
    {
        SceneManager.LoadScene(officeScene);
    }
}
