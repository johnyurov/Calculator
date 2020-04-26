using System.Collections;
using System.Collections.Generic;
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
       text.text += "1";
    }
    public void ClickButtonTwo()
    {
        text.text += "2";
    }
    public void ClickButtonThree()
    {
        text.text += "3";
    }
    public void ClickButtonFour()
    {
        text.text += "4";
    }
    public void ClickButtonFive()
    {
        text.text += "5";
    }
    public void ClickButtonSix()
    {
        text.text += "6";
    }
    public void ClickButtonSeven()
    {
        text.text += "7";
    }
    public void ClickButtonEight()
    {
        text.text += "8";
    }
    public void ClickButtonNine()
    {
        text.text += "9";
    }
    public void ClickButtonZero()
    {
        text.text += "0";
    }
    void Update()
    {
       // ClickButtons();
    }
}
