using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activer : MonoBehaviour
{
    public static bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void interact()
    {

        done = true;
        print("dans 1");


    }

    public bool ClickedButton()
    {
        print("dans 2");
        return done;
    }

    public void Desactiver()
    {
        done = false;
    }
}
