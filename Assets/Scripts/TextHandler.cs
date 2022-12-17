using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextHandler : MonoBehaviour
{

    public TextMeshProUGUI titleText;
    public string shapeLabel;

    // Start is called before the first frame update
    void Start()
    {
        DisplayName("Click a shape");
    }

    // Update is called once per frame
    void Update()
    {
        //DisplayName(shapeLabel);
    }

    public void DisplayName(string name)
    {
        Debug.Log(name);
        titleText.text = (name);
    }

}
