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
    public TextMeshProUGUI currentFundsGUI;
    public TextMeshProUGUI predictedFundsGUI;


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
        currentFundsGUI.text = "$" + GlobalVars.currentFunds;
        predictedFundsGUI.text = "$" + GlobalVars.predictedFunds;

    }

}
