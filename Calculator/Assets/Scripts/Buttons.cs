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

    public void ClickButtons()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            text.text += "1";
            Debug.Log("yes");
        }
    }
    void Update()
    {
        ClickButtons();
    }
}
