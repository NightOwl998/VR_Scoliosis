using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class HoverViewDirection : MonoBehaviour
{
    private bool hover = false;
    public GUIStyle style;
    private void Update()
    {



    }
    private void Start()
    {

        //hover = false;

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
            GUI.Label(new Rect(1240, 440, 500, 90), " \n Visualisation des informations sur les vertèbres \n  et calcul de l'angle de Cobb", style);
            Invoke("TurnValueFalse", 5);
            
        }

    }
   

    
}
