using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class VisualText : MonoBehaviour
{
    public InputField inputField;
    public GameObject textShow;
    public string text;
    public string textS;
    // Start is called before the first frame update


    // Update is called once per frame
    private void Start()
    {
        inputField.lineType = InputField.LineType.MultiLineNewline;

    }

    void Update()
    {
        textShow.GetComponent<Text>().text = inputField.text;
        
    }

    public void Read()
    {
        
    }
}
