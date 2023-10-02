using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejer8 : MonoBehaviour
{
    // Start is called before the first frame update
    // artray de objetos
    public GameObject[] objetos;
    // vector de floats para guardar las distancias
    public float[] distancias;
    void Start()
    {
        //inicializamos el array con los objetos con el tag "Eg2"
        objetos = GameObject.FindGameObjectsWithTag("Eg2");
        //inicializamos el array de floats con el tamaño del array de objetos
        distancias = new float[objetos.Length];
        //recorremos el array de objetos
        for (int i = 0; i < objetos.Length; i++)
        {
            //calculamos la distancia entre el objeto y el objeto con el tag "Eg1"
            distancias[i] = Vector3.Distance(objetos[i].transform.position, transform.position);
        }
        //recorremos el array de floats y nos quedamos con el menor y el mayor
        float menor = distancias[0];
        float mayor = distancias[0];

        for (int i = 0; i < distancias.Length; i++)
        {
            if (distancias[i] < menor)
            {
                menor = distancias[i];
            }
            if (distancias[i] > mayor)
            {
                mayor = distancias[i];
            }
        }

        // aumentamos la altura del objeto más cercano
        for (int i = 0; i < objetos.Length; i++)
        {
            if (distancias[i] == menor)
            {
                objetos[i].transform.position = new Vector3(objetos[i].transform.position.x, objetos[i].transform.position.y + 1, objetos[i].transform.position.z);
            }
        }

        // cambiamops el color del objeto más lejano
        for (int i = 0; i < objetos.Length; i++)
        {
            if (distancias[i] == mayor)
            {
                objetos[i].GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
