using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInOut : MonoBehaviour
{
     Camera mainCamera;
    public float zoomAMT = 60f;


    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    void Update()
    {
        mainCamera.fieldOfView = zoomAMT;
    }

    public void sliderZoom(float zoom)
    {
        zoomAMT = zoom;
    }
}
