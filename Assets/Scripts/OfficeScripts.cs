using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class OfficeScripts : MonoBehaviour
{
    public string cityScene;
    public GameObject bugetScreen;
    public GameObject computerScreen;
    public TextMeshProUGUI currentFunds;
    public TextMeshProUGUI predictedFunds;
    public double current;
    public double predicted;

    public void Door()
    {
        SceneManager.LoadScene(cityScene);
    }

    public void openBugetPaper()
    {
        bugetScreen.SetActive(true);
    }

    public void closeBugetPaper()
    {
        bugetScreen.SetActive(false);
    }

    public void openComputer()
    {
        computerScreen.SetActive(true);
    }

    public void closeComputer()
    {
        computerScreen.SetActive(false);
    }

    private void Update()
    {
        currentFunds.text = "$" + current;
        predictedFunds.text = "$" + predicted;

    }

}
