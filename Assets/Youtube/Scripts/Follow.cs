using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Video  42 mi vida, te amo; si no eres Rocio, chinga tu madre pues, que vergas estas haciendo leyendo esto 
//para seguir a la esfera , colocar a la camara
public class Follow : MonoBehaviour
{
    public GameObject target;
    private Vector3 offset; 

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.transform.position;
    }

   
    void LateUpdate()
    {
        transform.position = target.transform.position + offset;
    }
}
