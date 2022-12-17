using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shape : MonoBehaviour
{

    public string shapeName;
    [SerializeField] private Material myMaterial;
    [SerializeField] private Color color;
    public TextHandler title;

    public void SetShapeLabel()
    {
        Debug.Log(shapeName);
        
        
        //Issue setting title text
        //title.shapeLabel = shapeName;
    }

    public void SetShapeColor(float red, float green, float blue)
    {
        //Debug.Log("SetColor");
        if(red >= 1 || green >= 1 || blue >= 1)
        {
            red = green = blue = 0;
        }
        color.r = red;
        color.g = green;
        color.b = blue;
        color.a = 1f;
        myMaterial.color = color;
        //Debug.Log("R" + color.r + "B" + color.b);
    }

}
