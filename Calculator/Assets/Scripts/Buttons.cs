using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;


public class Buttons : MonoBehaviour
{
    public Text text;
    void Start()
    {
        
    }

    public void ClickButtonOne()
    {

       text.text += "56";
       int number = Convert.ToInt32(text);
        Debug.Log(number);
    }
    public void ClickButtonTwo()
    {
        text.text += "2";
        int number = Convert.ToInt32(text);
        Debug.Log(number);
    }
    public void ClickButtonThree()
    {
        text.text += "3";
        int number = Convert.ToInt32(text);
        Debug.Log(number);
    }
    public void ClickButtonFour()
    {
        text.text += "4";
        int number = Convert.ToInt32(text);
        Debug.Log(number);
    }
    public void ClickButtonFive()
    {
        text.text += "5";
        int number = Convert.ToInt32(text);
        Debug.Log(number);
    }
    public void ClickButtonSix()
    {
        text.text += "6";
        int number = Convert.ToInt32(text);
        Debug.Log(number);
    }
    public void ClickButtonSeven()
    {
        text.text += "7";
        int number = Convert.ToInt32(text);
        Debug.Log(number);
    }
    public void ClickButtonEight()
    {
        text.text += "8";
        int number = Convert.ToInt32(text);
        Debug.Log(number);
    }
    public void ClickButtonNine()
    {
        text.text += "9";
        int number = Convert.ToInt32(text);
        Debug.Log(number);
    }
    public void ClickButtonZero()
    {
        text.text += "0";
        int number = Convert.ToInt32(text);
        Debug.Log(number);
    }
    void Update()
    {
       // ClickButtons();
    }
}
