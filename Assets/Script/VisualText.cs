using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class VisualText : MonoBehaviour
{
    public GameObject inputField;
    public GameObject textShow;
    public string text=" ";
    // Start is called before the first frame update
    

    // Update is called once per frame
    

    void Update()
    {
        //int idtext = text.;
        //text += inputField.GetComponent<Text>().text.Substring(idtext, 1);
        ////text = inputField.GetComponent<Text>().text;
        //textShow.GetComponent<Text>().text=text;
    }

    public void Read()
    {
        int idtext = text.Length;
        Debug.Log(idtext);
        
        text += inputField.GetComponent<Text>().text.Substring(idtext,1);
        
    }
}
