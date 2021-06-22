using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroll : MonoBehaviour
{
    public Scrollbar bar;
    public Camera cam;
    private static bool max = false;
    public GameObject avant, apres, present;
    public GUIStyle style;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void montrer()
    {

        if (bar.value > 0 & bar.value < 1)
        {
            avant.SetActive(false);
            apres.SetActive(false);
            present.SetActive(true);
        }

        if (bar.value == 0)
        {
            avant.SetActive(true);
            present.SetActive(false);
            apres.SetActive(false);


        }

        if (bar.value == 1)
        {
            avant.SetActive(false);
            present.SetActive(false);
            apres.SetActive(true);

        }

        //avant.SetActive(true);
        //apres.SetActive(false);
        //
    }

    public void OnGUI()
    {
        if (bar.value > 0 & bar.value < 1)
        {
            GUI.Label(new Rect(200, 100, 500, 30), "Etat intérmediaire", style);
        }

        if (bar.value == 0)
        {
            GUI.Label(new Rect(200, 100, 500, 30), "Avant", style);
        }

        if (bar.value == 1)
        {
            GUI.Label(new Rect(200, 100, 500, 30), "Après", style);
        }
    }


}
