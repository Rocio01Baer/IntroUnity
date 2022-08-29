using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private bool _rotate;

    void Update()
    {
        
    }

    public void OnPress()
    {
        transform.rotation = Quaternion.identity;
    }

   
}
