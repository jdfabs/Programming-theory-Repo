using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shapes : MonoBehaviour
{

    private string shape;
    protected int[] color;

    protected void PrintProperties()
    {
        Debug.Log("Shape: " + shape + " color: R:" +
           color[0] + " B:" +
           color[1] + " G:" +
           color[2]);
    }
    protected void SetShape()
    {
        shape =  gameObject.name.Remove(gameObject.name.Length-7,7);

    }

    protected void SetColor()
    {
        float r = RandomValue(1);
        float b = RandomValue(1);
        float g = RandomValue(1);

        gameObject.GetComponent<Renderer>().material.color = new Color(r, b, g);

        color[0] = Mathf.RoundToInt(r * 255);
        color[1] = Mathf.RoundToInt(b * 255);
        color[2] = Mathf.RoundToInt(g * 255);

    }
    protected float RandomValue(float maxValue)
    {
        float value;
        value = Random.Range(0, maxValue);
        return value;
    }

}
