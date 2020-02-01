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
    Transform firstBox;
    Transform secondBox;
    public Transform actualBox;

    // Start is called before the first frame update
    void Start()
    {
        isPlacing = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlacing && isFirstBlockSelected && !isSecondBlockSelected)
        {

        }
        else if (isPlacing && isFirstBlockSelected && isSecondBlockSelected)
        {
            isPlacing = false;
        }
    }

    private void OnMouseDown()
    {
        if (isPlacing && !isFirstBlockSelected)
        {
            firstBox = actualBox;
            isFirstBlockSelected = true;
        }
    }
    private void OnMouseUp()
    {
        if (isPlacing && isFirstBlockSelected && !isSecondBlockSelected)
        {
            secondBox = actualBox;
            isSecondBlockSelected = true;
        }
    }
}
