using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metronome : MonoBehaviour
{
    private EditorManager em;
    
    public AudioSource tikSound;
    
    public float tikTime = 0;
    public float nextTime = 0;
    
    void Start()
    {
        em = EditorManager.instance;
        tikSound = GetComponent<AudioSource>();
        tikTime = 60 / em.bpm;
    }
    
    void Update()
    {
        if (em.isPressed)
            nextTime += Time.deltaTime;
        
        if (nextTime >= tikTime && em.isPressed)
        {
            Debug.Log("nextTime: " + nextTime);
            
            tikSound.Play();
            
            nextTime = 0;
        }
    }
}
