using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class View3D : MonoBehaviour
{
    private float movementSpeed = 10;
    private float turningSpeed = 60;
    public GameObject objet;
    public Scrollbar bar;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            Vector3 coord = objet.transform.position;
            float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
            objet.transform.Rotate(coord.x, horizontal, coord.z);
            coord = objet.transform.position;
            float vertical = Input.GetAxis("Vertical") * turningSpeed * Time.deltaTime;
        objet.transform.Rotate(coord.x, vertical, coord.z);
       

    }
}
