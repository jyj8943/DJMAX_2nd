using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorManager : MonoBehaviour
{
    public static EditorManager instance = null;

    public float bpm = 60;
    public bool isPressed = false;
    
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
