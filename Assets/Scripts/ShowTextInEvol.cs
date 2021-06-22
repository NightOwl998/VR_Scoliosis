using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTextInEvol : MonoBehaviour
{
    public GUIStyle style;
    private bool state = true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
   
    public void OnGUI()
    {

        
            GUI.Label(new Rect(1200, 50, 750, 300), " \n \n \n appuyer sur les flèches de clavier pour faire pivoter le modelé 3D \n\n Utiliser le scroller pour visualiser l'evolution de rachis", style);
          
        
    }
}
