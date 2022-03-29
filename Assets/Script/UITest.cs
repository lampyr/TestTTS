using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITest : MonoBehaviour
{
    public GameObject canvas;

    public void ShowTTS()
    {
        canvas.gameObject.SetActive(true);
    }

    public void ExitTTS()
    {
        canvas.gameObject.SetActive(false);
    }
}
