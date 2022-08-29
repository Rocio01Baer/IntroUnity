using UnityEngine;
using UnityEngine.UI;

public class RotateWithSlider : MonoBehaviour
{
/*
 
    public float speed = 1f;
   // public GameObject ObjectToRotate;

    public void RotateMyObject()
    {
        float sliderValue = GameObject.Find("Slider").GetComponent<Slider>().value;
        this.gameObject.transform.rotation = Quaternion.Euler(sliderValue * 360, 0, 90);
    }*/
        /*public Slider xSlider, ySlider, zSlider; //set in editor
         public GameObject objectToRotate; //set in editor
         private readonly float rotationLimit = 180f;

         public void RotateObject()
         {
              objectToRotate.transform.localEulerAngles = new Vector3(
                  xSlider.value * rotationLimit,
                  ySlider.value * rotationLimit,
                  zSlider.value * rotationLimit //y-up, switch ySlider & zSlider for z-up

              );
             //objectToRotate.transform.localEulerAngles = Vector3.right * xSlider.value * rotationLimit;
         }*/
        // Assign in the inspector
        public GameObject objectToRotate;
        public Slider slider;

        // Preserve the original and current orientation
        private float previousValue;

        public Slider slidery;

        // Preserve the original and current orientation
        private float previousValuey;

       // public Slider sliderz;

        // Preserve the original and current orientation
        //private float previousValuez;

        void Awake()
        {
            // Assign a callback for when this slider changes
            this.slider.onValueChanged.AddListener(this.OnSliderChanged);

            // And current value
            this.previousValue = this.slider.value;

            // Assign a callback for when this slider changes
            this.slidery.onValueChanged.AddListener(this.OnSliderYChanged);

            // And current value
            this.previousValuey = this.slidery.value;
            // Assign a callback for when this slider changes
            //this.sliderz.onValueChanged.AddListener(this.OnSliderZChanged);

            // And current value
            //this.previousValuez = this.sliderz.value;
        }

        void OnSliderChanged(float value)
        {
            // How much we've changed
            float delta = value - this.previousValue;
            this.objectToRotate.transform.Rotate(Vector3.right * delta * 360);

            // Set our previous value for the next change
            this.previousValue = value;
        }
        void OnSliderYChanged(float value)
        {
            // How much we've changed
            float delta = value - this.previousValuey;
            this.objectToRotate.transform.Rotate(delta * Vector3.up * 360);

            // Set our previous value for the next change
            this.previousValuey = value;
        }
      /*  void OnSliderZChanged(float value)
        {
            // How much we've changed
            float delta = value - this.previousValuey;
            this.objectToRotate.transform.Rotate(delta * Vector3.left * 360);

            // Set our previous value for the next change
            this.previousValuey = value;
        }*/
    }