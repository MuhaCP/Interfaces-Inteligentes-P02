using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Align : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 posicionEsfera;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        posicionEsfera = GameObject.Find("Sphere").transform.position;
        
        if (gameObject.name == "Cube")
        {
            transform.position = new Vector3(posicionEsfera.x + 5, posicionEsfera.y, posicionEsfera.z);
        }
        else if (gameObject.name == "Cylinder")
        {
            transform.position = new Vector3(posicionEsfera.x + 10, posicionEsfera.y, posicionEsfera.z);
        }
    }
}
