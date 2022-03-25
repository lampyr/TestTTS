using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ReadSpeaker;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class TTSScript : MonoBehaviour
{
    public GameObject inputField;
    public GameObject textShow;
    private TTSSpeaker speaker;
    private VisualText text;
    // Start is called before the first frame update
    void Start()
    {
        TTS.Init();
        speaker = GetComponent<TTSSpeaker>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //text = inputField.GetComponent<Text>().text;
            //TTS.SayAsync(text, speaker);
            Speak();
        }
    }

    public void Speak()
    {
        
        
        TTS.SayAsync(text.text, speaker);
    }

    
}
