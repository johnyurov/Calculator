using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;
using UnityEngine.UI;

public class CalculatorLogic : MonoBehaviour
{
    public Text text;
    private string[] strCount = new string[20];
    private double[] intCount = new double[20];
    private int number = 0;

    public void Plus()
    {
        text.text += "+";
    }
    public void Equals()
    {
        text.text += "=";
        for (int i = 0; i < number; i++)
        {
            intCount[i] = Convert.ToDouble(strCount[i]);
            Console.WriteLine(intCount[i]);
            Debug.Log("yes");
        }
    }
    void CountNumbers()
    {
        for(int i = 0; i<20;i++)
        {
            strCount[i] = text.text;
            number++;
            if(text.text == "=")
            {
                break;
            }
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
