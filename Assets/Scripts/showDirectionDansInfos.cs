using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showDirectionDansInfos : MonoBehaviour
{
    public GUIStyle style;
    private bool state = true;
    // Start is called before the first frame update
    void Start()
    {
        state = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TurnValueFalse()
    {
        state = false;
        
    }
    public void OnGUI()
    {

        if (state)
        {
            GUI.Label(new Rect(500, 150, 1000, 500), " \n \n \n l'angle de Cobb est C'est l'angle formé à partir de l'intersection de deux droites tangentielles l'une au plateau supérieur de la vertèbre limite supérieure, l'autre au plateau inférieur de la vertèbre limite inférieure.\n\n Les conventions médicales veulent qu'un angle inférieur à 10 degrés ne soit pas considéré comme une scoliose à part entière.\n\n\n  Pour calculer angle Cobb Cliquez d'abord sur le boutton angle Cobb puis sélectionnez deux vertèbres", style);
            Invoke("TurnValueFalse", 15);
        }
    }
}
