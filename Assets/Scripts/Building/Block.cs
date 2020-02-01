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
        ElementsPlacer.instance.actualBlock = transform;
    }

    private void OnMouseExit()
    {
        ElementsPlacer.instance.actualBlock = null;
    }

    private void OnMouseOver()
    {
        if (ElementsPlacer.instance.actualBlock != transform)
            ElementsPlacer.instance.actualBlock = transform;
    }
}
