using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shapes
{
    // Start is called before the first frame update
    void Start()
    {
        color = new int[3];
        SetShape();
        SetColor();
        PrintProperties();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
