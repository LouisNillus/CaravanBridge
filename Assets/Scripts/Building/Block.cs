using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        ElementsPlacer.instance.actualBox = transform;
    }

    private void OnMouseExit()
    {
        ElementsPlacer.instance.actualBox = null;
    }

    private void OnMouseOver()
    {
        if (ElementsPlacer.instance.actualBox != transform)
            ElementsPlacer.instance.actualBox = transform;
    }
}
