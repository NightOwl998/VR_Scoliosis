using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Between : MonoBehaviour
{
    // Start is called before the first frame update
    public Scrollbar bar;
    public GameObject avant, present, apres;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bar.value > 0.0f & bar.value < 0.5f)
        {
            present.transform.position = Vector3.Lerp(avant.transform.position, apres.transform.position, 0.55f);
            if (Input.GetKey("left") == false & Input.GetKey("right") == false)
            { present.transform.rotation = Quaternion.Lerp(avant.transform.rotation, apres.transform.rotation, 0.55f); }
        }
        if (bar.value >= 0.5f & bar.value < 1.0f)
        {
            present.transform.position = Vector3.Lerp(avant.transform.position, apres.transform.position, 0.75f);
            if (Input.GetKey("left") == false & Input.GetKey("right") == false)
            { present.transform.rotation = Quaternion.Lerp(avant.transform.rotation, apres.transform.rotation, 0.75f); }
           
        }      
    }


}
