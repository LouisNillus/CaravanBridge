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

        this.GetComponent<SpriteRenderer>().color = Color.cyan;

    }

    private void OnMouseExit()
    {
        ElementsPlacer.instance.actualBlock = null;

        this.GetComponent<SpriteRenderer>().color = Color.white;
    }

    private void OnMouseOver()
    {
        if(CheckBlock())
        {
            //Code
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
