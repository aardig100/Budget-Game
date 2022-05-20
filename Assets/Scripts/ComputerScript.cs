using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ComputerScript : MonoBehaviour
{

    [SerializeField] private Slider libSlider = null;
    [SerializeField] private Slider gymSlider = null;
    [SerializeField] private Slider fundSlider = null;

    [SerializeField] private TextMeshProUGUI libText = null;
    [SerializeField] private TextMeshProUGUI gymText = null;
    [SerializeField] private TextMeshProUGUI fundText = null;

    private double totalfunds;
    public double current;
    public double predicted;

    public GameObject menu;


    void Start()
    {
        totalfunds = current + predicted;
        fundSlider.minValue = 0;
        libSlider.minValue = 0;
        gymSlider.minValue = 0;

        fundSlider.value = 0;

        fundSlider.maxValue = (float)totalfunds;
        libSlider.maxValue = fundSlider.value;
        gymSlider.maxValue = fundSlider.value;

        libSlider.value = 0;
        gymSlider.value = 0;

        libSlider.onValueChanged.AddListener(delegate { libValueChangeCheck(); });
        gymSlider.onValueChanged.AddListener(delegate { gymValueChangeCheck(); });
        fundSlider.onValueChanged.AddListener(delegate { fundValueChangeCheck(); });
    }

    void libValueChangeCheck()
    {
        gymSlider.value = gymSlider.maxValue - libSlider.value;
    }

    void gymValueChangeCheck()
    {
        libSlider.value = libSlider.maxValue - gymSlider.value;
    }

    void fundValueChangeCheck()
    {
        float ratio = 0;
        float rval1;
        float rval2;
        if (gymSlider.value != 0 && libSlider.value != 0)
        {
            ratio = libSlider.value / gymSlider.value;
            rval1 = libSlider.value * ratio;
            rval2 = gymSlider.value * (1 / ratio);
            libSlider.value = rval1;
            gymSlider.value = rval2;
            libSlider.maxValue = fundSlider.value;
            gymSlider.maxValue = fundSlider.value;
        }
        else
        {
            libSlider.maxValue = fundSlider.value;
            gymSlider.maxValue = fundSlider.value;
            libSlider.value = 0;
            gymSlider.value = gymSlider.maxValue;
        }
    }

    public void openMenu()
    {
        menu.SetActive(!menu.activeSelf);
    }


    private void Update()
    {
        libText.text = libSlider.value.ToString();
        gymText.text = gymSlider.value.ToString();
        fundText.text = fundSlider.value.ToString();
    }



}
