using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleAndRotateSlider : MonoBehaviour
{
    //we need two sliders
    //we need min and max values of each 

    private Slider scaleSlider;
    public Slider rotateSlider1;
    public Slider rotateSlider2;

    public float scaleMinValue;
    public float scaleMaxValue;

    public float rotXZMinValue;
    public float rotXZMaxValue;

    public float rotYMinValue;
    public float rotYMaxValue;

    float speed = 0.1f;
    void Start()
    {
        //find the sliders by name 
        //initialize the max and min value when starting 
        //Add a listener to the slider when value is changed

        scaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();
        scaleSlider.minValue = scaleMinValue;
        scaleSlider.maxValue = scaleMaxValue;

        scaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);
        //Rotation XZ
       // rotateSlider = GameObject.Find("RotateXZSlider").GetComponent<Slider>();
        rotateSlider1.minValue = rotXZMinValue;
        rotateSlider1.maxValue = rotXZMaxValue;

        rotateSlider1.onValueChanged.AddListener(RotateXZSliderUpdate);

        //Rotation Y
        //rotateSlider = GameObject.Find("RotateYSlider").GetComponent<Slider>();
        rotateSlider2.minValue = rotYMinValue;
        rotateSlider2.maxValue = rotYMaxValue;

        rotateSlider2.onValueChanged.AddListener(RotateYSliderUpdate);

    }

    void ScaleSliderUpdate(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }


    void RotateXZSliderUpdate(float value)
    {
        //transform.localEulerAngles = new Vector3(transform.rotation.x, value, transform.rotation.z);
        //transform.localEulerAngles = new Vector3(mySlider.value * xLimit, transform.localEulerAngles.y, transform.localEulerAngles.z);
        transform.localEulerAngles = new Vector3(rotateSlider1.value * rotXZMaxValue * Time.deltaTime * speed, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }

    void RotateYSliderUpdate(float value)
    {
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, rotateSlider2.value * rotYMaxValue*Time.deltaTime*speed, transform.localEulerAngles.z);
    }

}
