using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rand25 : MonoBehaviour
{
    // Start is called before the first frame update
    int[] numeros = new int[10];
    public int rangoInferior = 0;
    public int rangoSuperior = 26;
    void Start()
    {

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = Random.Range(rangoInferior, rangoSuperior);
        }
    }

    // Update is called once per frame
    void Update()
    {
        numeros[Random.Range(0, 10)] = Random.Range(rangoInferior, rangoSuperior);

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] > 15)
            {
                Debug.Log(numeros[i]);
            }
        }
    }
}
