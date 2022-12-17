using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
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
        //Debug.Log("Cube color = " + colorValue);
        SetShapeColor(.5f, .5f, colorValue);
        colorValue += .2f;
        if (colorValue >= 1) colorValue = .2f;
        SetShapeLabel();
    }
}
