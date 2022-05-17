using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CityNode : MonoBehaviour
{
    public string name;

    public int quality;
    public int totalFunding;
    public GameObject Panel;
    
    public TextMeshProUGUI tex1;
    public TextMeshProUGUI tex2;
    public TextMeshProUGUI tex3;

    private void OnMouseDown()
    {
        TogglePanel();
    }

    private void TogglePanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }
    int i = 0;
    private void Update()
    {
        tex1.text = "Building: " + name;
        tex2.text = "Quality: " + quality;
        tex3.text = "Funding: " + totalFunding;

        
        i++;

        if(i%60 == 0)
        {
            totalFunding += 1;
            
            if(totalFunding % 100 == 0)
                quality+= totalFunding;
        }
        
    }

}
