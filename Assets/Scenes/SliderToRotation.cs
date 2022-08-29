using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderToRotation : MonoBehaviour
{
    public Slider mySlider;
    public Slider mySlider2;

    public float xLimit = 0f;
    public float yLimit = 0f;

    public bool xRot;
    public bool yRot;

    void Start()
    {
        mySlider.onValueChanged.AddListener(delegate
        {
            RotateMe();
        });
    }

    public void RotateMe()
    {
        if(xRot)
        transform.localEulerAngles = new Vector3(mySlider.value * xLimit, transform.localEulerAngles.y, transform.localEulerAngles.z);
        if(yRot)
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, mySlider.value * yLimit, transform.localEulerAngles.z);
    }
   

}
