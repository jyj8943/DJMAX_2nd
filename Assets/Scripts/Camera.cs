using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private EditorManager em;
    
    void Start()
    {
        em = EditorManager.instance;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (em.isPressed == true)
                em.isPressed = false;
            else if (em.isPressed == false)
                em.isPressed = true;
        }

        if (em.isPressed)
        {
            gameObject.transform.Translate(new Vector3(0, 1 * Time.deltaTime, 0));
        }
    }
}
