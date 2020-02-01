using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementsPlacer : MonoBehaviour
{
    public static ElementsPlacer instance;
    private void Awake() { instance = this; }

    public bool isPlacing;
    bool isFirstBlockSelected;
    bool isSecondBlockSelected;
    Transform firstBlock;
    Transform secondBlock;
    public Transform actualBlock;

    // Start is called before the first frame update
    void Start()
    {
        isPlacing = true;
    }

    // Update is called once per frame
    void Update()
    {
        Placing();
    }

    private void OnMouseDown()
    {
        if (isPlacing && !isFirstBlockSelected && ac)
        {
            firstBlock = actualBlock;
            isFirstBlockSelected = true;
        }
    }
    private void OnMouseUp()
    {
        if (isPlacing && isFirstBlockSelected && !isSecondBlockSelected)
        {
            secondBlock = actualBlock;
            isSecondBlockSelected = true;
        }
    }

    void Placing()
    {
        if (isPlacing && isFirstBlockSelected && !isSecondBlockSelected)
        {

        }
        else if (isPlacing && isFirstBlockSelected && isSecondBlockSelected)
        {
            isPlacing = false;
        }

    }
}
