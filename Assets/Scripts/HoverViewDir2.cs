using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class HoverViewDir2 : MonoBehaviour
{
    private bool hover = false;
    public GUIStyle style;
    private void Update()
    {



    }
    private void Start()
    {

        

    }
    public void OnMouseOver()
    {
        hover = true;
        

    }
    public void TurnValueTrue()
    {
        hover = true;
        


    }
    public void TurnValueFalse()
    {
        hover = false;
        
    }
    public void OnGUI()
    {
        if (hover)
        {
            GUI.Label(new Rect(240, 440, 350, 90), " \n visulaisation de l'evolution de rachis ", style);
            Invoke("TurnValueFalse", 5);
           
        }

    }



}
