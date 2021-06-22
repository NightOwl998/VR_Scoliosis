using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public TMP_Dropdown Patient;
    public Toggle chooseInformation;
    public Toggle chooseEvolution;
    public void ValiderClicked()
    {
        
        if((Patient.value==0) & (chooseInformation.isOn))
        {
            
            SceneManager.LoadScene("PatientN1");
        }
        if ((Patient.value == 1) & (chooseInformation.isOn))
        {
            
            SceneManager.LoadScene("PatientN2");
        }
        if ((Patient.value == 2) & (chooseInformation.isOn))
        {
            
            SceneManager.LoadScene("PatientN3");
        }
        if ((Patient.value == 0) & (chooseEvolution.isOn))
        {
            
            SceneManager.LoadScene("EvolutionPatient1");
        }
        if ((Patient.value == 1) & (chooseEvolution.isOn))
        {
            
            SceneManager.LoadScene("EvolutionPatient2");
        }
        if ((Patient.value == 2) & (chooseEvolution.isOn))
        {
            
            SceneManager.LoadScene("EvolutionPatient3");
        }
    }
    public void QuitterClicked()
    {
        EditorApplication.isPlaying = false;
       // Application.Quit();
    }
   
}
