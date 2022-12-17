using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    [SerializeField] private float colorValue = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        //Debug.Log("Sphere color = " + colorValue);        
        SetShapeColor(colorValue,.5f,.5f);
        colorValue += .2f;
        if (colorValue >= 1) colorValue = .2f;
        SetShapeLabel();

    }
}
