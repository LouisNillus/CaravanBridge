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

    [SerializeField] Transform ElementsParent = default;
    [SerializeField] GameObject RopePrefab = default;
    [SerializeField] GameObject RodPrefab = default;
    [SerializeField] GameObject TendeurPrefab = default;
    [SerializeField] GameObject PlankPrefab = default;
    GameObject NewElement;

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
            Debug.Log("Second Block Selected");
            secondBlock = actualBlock;
            isSecondBlockSelected = true;
        }
    }

    void Placing()
    {
        if (isPlacing && isFirstBlockSelected && !isSecondBlockSelected)
        {
            Debug.DrawLine(firstBlock.position, mousePos, Color.blue);
        }
        else if (isPlacing && isFirstBlockSelected && isSecondBlockSelected)
        {
            isPlacing = false;
            Debug.DrawLine(firstBlock.position, secondBlock.position, Color.red);
            PlaceTendeur();
            ResetSelection();
        }

    }

    private void ResetSelection()
    {
        firstBlock = null;
        secondBlock = null;
        isFirstBlockSelected = false;
        isSecondBlockSelected = false;
        isPlacing = true;
    }


    //DistanceJoint2D = barre orientable
    //DistanceJoint2D avec max distance only = corde
    //DistanceJoint2D avec max distance only & !auto configure distance & distance -- = tendeur
    //FixedJoint2D = Planche

    void PlaceRope()
    {
        firstBlock.gameObject.AddComponent<DistanceJoint2D>();
        firstBlock.GetComponent<DistanceJoint2D>().connectedBody = secondBlock.GetComponent<Rigidbody2D>();
        firstBlock.GetComponent<DistanceJoint2D>().enableCollision = true;
        firstBlock.GetComponent<DistanceJoint2D>().maxDistanceOnly = false;
        NewElement = Instantiate(RopePrefab, firstBlock.position, Quaternion.identity, ElementsParent);
        NewElement.GetComponent<Element>().type = Element.ElementsType.Rope;
        NewElement.GetComponent<Element>().SetAttachedBlocks(firstBlock, secondBlock);
    }
    void PlacePlank()
    {
        firstBlock.gameObject.AddComponent<FixedJoint2D>();
        firstBlock.GetComponent<FixedJoint2D>().connectedBody = secondBlock.GetComponent<Rigidbody2D>();
        firstBlock.GetComponent<FixedJoint2D>().enableCollision = true;
        NewElement = Instantiate(RopePrefab, firstBlock.position, Quaternion.identity, ElementsParent);
        NewElement.GetComponent<Element>().type = Element.ElementsType.Plank;
        NewElement.GetComponent<Element>().SetAttachedBlocks(firstBlock, secondBlock);
    }
    void PlaceRod()
    {
        firstBlock.gameObject.AddComponent<DistanceJoint2D>();
        firstBlock.GetComponent<DistanceJoint2D>().connectedBody = secondBlock.GetComponent<Rigidbody2D>();
        firstBlock.GetComponent<DistanceJoint2D>().enableCollision = true;
        NewElement = Instantiate(RopePrefab, firstBlock.position, Quaternion.identity, ElementsParent);
        NewElement.GetComponent<Element>().type = Element.ElementsType.Rod;
        NewElement.GetComponent<Element>().SetAttachedBlocks(firstBlock, secondBlock);
    }
    void PlaceTendeur()
    {
        firstBlock.gameObject.AddComponent<DistanceJoint2D>();
        firstBlock.GetComponent<DistanceJoint2D>().connectedBody = secondBlock.GetComponent<Rigidbody2D>();
        firstBlock.GetComponent<DistanceJoint2D>().enableCollision = true;
        firstBlock.GetComponent<DistanceJoint2D>().maxDistanceOnly = false;
        NewElement = Instantiate(RopePrefab, firstBlock.position, Quaternion.identity, ElementsParent);
        NewElement.GetComponent<Element>().type = Element.ElementsType.Tendeur;
        NewElement.GetComponent<Element>().SetAttachedBlocks(firstBlock, secondBlock);
    }
}
