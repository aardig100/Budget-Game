using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVars : MonoBehaviour
{
    public static double currentFunds = 0;
    public static double predictedFunds = 0;
    public static double LibFunds = 0;
    public static double GymFunds = 0;

    void Start()
    {
        currentFunds = 500;
        predictedFunds = 500;
        LibFunds = 0;
        GymFunds = 0;
    }
}
