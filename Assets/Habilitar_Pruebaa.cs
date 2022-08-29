using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Habilitar_Pruebaa : MonoBehaviour
{
    public GameObject n1, n2, n3, n4, n5;
   // public Canvas menuCanvas;


    void Start()
    {
        Invoke("RestartPosition", 5f);
    }

    void RestartPosition()
    {
       // menuCanvas.enabled = true;
    
        n1.SetActive(true);
        n2.SetActive(true);
        n3.SetActive(true);
        n4.SetActive(true);
        n5.SetActive(true);
    }
}