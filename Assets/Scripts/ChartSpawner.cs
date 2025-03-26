using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ChartSpawner : MonoBehaviour
{
    private EditorManager em;
    public GameObject lineGrid4;
    
    void Start()
    {
        em = EditorManager.instance;
        
        Spawn4Line();
    }
    
    void Update()
    {
        
    }

    private void Spawn4Line()
    {
        for (int i = 0; i < (em.maxChartHeight * 16) - 3; i++)
        {
            var tmpPos = new Vector3(0, (4 * i) - 3, 0);
            var tmpLine = GameObject.Instantiate(em.fourBitLine, tmpPos, quaternion.identity);
            tmpLine.transform.parent = lineGrid4.transform;
        }
    }
}
