using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    // Start is called before the first frame update
    float distanciaCubo;
    float distanciaCilindro;


    void Start()
    {
        distanciaCubo = Vector3.Distance(transform.position, GameObject.Find("Cube").transform.position);
        distanciaCilindro = Vector3.Distance(transform.position, GameObject.Find("Cylinder").transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("La posición de la esfera es: " + transform.position);
        Debug.Log("La distancia entre el cubo y la esfera es: " + distanciaCubo);
        Debug.Log("La distancia entre el cilindro y la esfera es: " + distanciaCilindro);
    }
}
