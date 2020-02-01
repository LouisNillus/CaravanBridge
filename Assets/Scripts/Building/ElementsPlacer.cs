using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementsPlacer : MonoBehaviour
{
    public static ElementsPlacer instance;
    private void Awake() { instance = this; }

    Vector2 mousePos;
    [SerializeField] Camera myCamera = default;

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
        mousePos = myCamera.ScreenToWorldPoint(Input.mousePosition);
        Placing();
        if (Input.GetMouseButtonDown(0)) MouseDown();
        if (Input.GetMouseButtonUp(0)) MouseUp();
    }

    private void MouseDown()
    {
        if (actualBlock == null) { ResetSelection(); return; }

        if (isPlacing && !isFirstBlockSelected)
        {
            Debug.Log("First Block Selected");
            firstBlock = actualBlock;
            isFirstBlockSelected = true;
        }
    }
    private void MouseUp()
    {
        if (actualBlock == null) { ResetSelection(); return; }

        if (isPlacing && isFirstBlockSelected && !isSecondBlockSelected)
        {
            if(firstBlock == actualBlock)
            {
                ResetSelection();
                return;
            }
            Debug.Log("Sedond Block Selected");
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

            ResetSelection();
        }

    }

    private void ResetSelection()
    {
        firstBlock = null;
        secondBlock = null;
        isFirstBlockSelected = false;
        isSecondBlockSelected = false;
    }
}
