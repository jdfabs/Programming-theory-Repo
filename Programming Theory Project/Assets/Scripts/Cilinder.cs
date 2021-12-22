using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cilinder : Shapes
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

    protected override void PrintProperties()
    {
        Debug.Log("The colors of this Cilinder are: R:" +
          color[0] + " B:" +
          color[1] + " G:" +
          color[2]);
    }
}
