using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{

    public Camera camera;
    public int limiteSuperior = 100;
    public int limiteInferior =2;

    void Update()
    {
        //Rueda del mouse haca arriba
        if (Input.GetAxis("Mouse ScrollWheel") > 0 && camera.fieldOfView > limiteInferior)
        {
           // Camera.main.fieldOfView; //Tag=MainCamera
            camera.fieldOfView--;
        }
        //Rueda deñ mouse hacia abajo 
        if (Input.GetAxis("Mouse ScrollWheel") < 0 && camera.fieldOfView < limiteSuperior)
        {
            //Camera.main.fieldOfViev; //Tag=MainCamera
            camera.fieldOfView++;
        }
    }
}
