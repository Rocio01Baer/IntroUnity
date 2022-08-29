using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eruption : MonoBehaviour
{
    public GameObject stone; //piezas mami
    public float fireRate = 0.5f; // cada medio segundo se pretende tirar los cubos
    //public float nextFire = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ThrowStone());
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate; // enelinstanteactual+enmediosegundos
            Instantiate(stone, transform.position, Random.rotation);
        } */
    }
    IEnumerator ThrowStone()
    {
        yield return new WaitForSeconds(2f);
        while (true)
        {
            Instantiate(stone, transform.position, Random.rotation);
            yield return new WaitForSeconds(fireRate);
        }
    }
}
