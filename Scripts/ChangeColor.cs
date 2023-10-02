using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Cube" && Input.GetKeyDown(KeyCode.UpArrow)) {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        else if (gameObject.name == "Cylinder" && Input.GetKeyDown(KeyCode.A)) {
            gameObject.GetComponent<Renderer>().material.color = Color.black;
        }
    }
}
