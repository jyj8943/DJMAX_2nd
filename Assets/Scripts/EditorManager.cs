using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorManager : MonoBehaviour
{
    public static EditorManager instance = null;

    public GameObject fourBitLine;
    
    public float bpm = 60;
    public bool isPressed = false;
    public int maxChartHeight = 4;
    
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }
    
}
