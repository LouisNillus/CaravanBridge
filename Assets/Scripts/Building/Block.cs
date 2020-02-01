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
        if(CheckBlock())
        {
            Debug.Log(0);
        }
    }

    private bool CheckBlock()
    {
        if (ElementsPlacer.instance.actualBlock != transform)
        {
            ElementsPlacer.instance.actualBlock = transform;
            return true;
        }
        else
        {
            return true;
        }

    }

}
