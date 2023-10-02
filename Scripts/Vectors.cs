using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 vector1 = new Vector3(0, 0, 0);
    public Vector3 vector2 = new Vector3(0, 0, 0);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("La magnitud del vector 1 es: " + vector1.magnitude);
        Debug.Log("La magnitud del vector 2 es: " + vector2.magnitude);

        Debug.Log("El ángulo que forman es: " + Vector3.Angle(vector1, vector2));

        Debug.Log("La distancia entre es: " + Vector3.Distance(vector1, vector2));

        if (vector1.y > vector2.y)
        {
            Debug.Log("El vector 1 está a más alto");
        }
        else
        {
            Debug.Log("El vector 2 está a más alto");
        }        
    }
}
