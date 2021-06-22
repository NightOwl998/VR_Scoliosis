using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retourScript : MonoBehaviour
{
    public void retourClicked()
    {
        SceneManager.LoadScene("MainPage");
    }
}
