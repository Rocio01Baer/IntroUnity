using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myDrop : MonoBehaviour
{
    public GameObject Sistema_Oseo;
    public GameObject Sistema_Muscular;
    public GameObject Sistema_Nervioso;
    public GameObject Sistema_Cardiovascular;
    public GameObject Articulaciones;
    public GameObject Sistema_Visceral;
    public TMPro.TMP_Dropdown My_Drop;
    public void DropDownFunctioning()
    {
        if (My_Drop.value == 0)
        {
            Sistema_Oseo.SetActive(false);
            Sistema_Muscular.SetActive(false);
            Sistema_Nervioso.SetActive(false);
            Sistema_Cardiovascular.SetActive(false);
            Articulaciones.SetActive(false);
            Sistema_Visceral.SetActive(false);
        }

        if (My_Drop.value == 1)
        {
            Sistema_Oseo.SetActive(true);
            Sistema_Muscular.SetActive(false);
            Sistema_Nervioso.SetActive(false);
            Sistema_Cardiovascular.SetActive(false);
            Articulaciones.SetActive(false);
            Sistema_Visceral.SetActive(false);
        }

        if (My_Drop.value == 2)
        {
            Sistema_Oseo.SetActive(false);
            Sistema_Muscular.SetActive(true);
            Sistema_Nervioso.SetActive(false);
            Sistema_Cardiovascular.SetActive(false);
            Articulaciones.SetActive(false);
            Sistema_Visceral.SetActive(false);
        }

        if (My_Drop.value == 3)
        {
            Sistema_Oseo.SetActive(false);
            Sistema_Muscular.SetActive(false);
            Sistema_Nervioso.SetActive(true);
            Sistema_Cardiovascular.SetActive(false);
            Articulaciones.SetActive(false);
            Sistema_Visceral.SetActive(false);
        }

        if (My_Drop.value == 4)
        {
            Sistema_Oseo.SetActive(false);
            Sistema_Muscular.SetActive(false);
            Sistema_Nervioso.SetActive(false);
            Sistema_Cardiovascular.SetActive(true);
            Articulaciones.SetActive(false);
            Sistema_Visceral.SetActive(false);
        }

        if (My_Drop.value == 5)
        {
            Sistema_Oseo.SetActive(false);
            Sistema_Muscular.SetActive(false);
            Sistema_Nervioso.SetActive(false);
            Sistema_Cardiovascular.SetActive(false);
            Articulaciones.SetActive(true);
            Sistema_Visceral.SetActive(false);
        }

        if (My_Drop.value == 6)
        {
            Sistema_Oseo.SetActive(false);
            Sistema_Muscular.SetActive(false);
            Sistema_Nervioso.SetActive(false);
            Sistema_Cardiovascular.SetActive(false);
            Articulaciones.SetActive(false);
            Sistema_Visceral.SetActive(true);
        }

    }
}
