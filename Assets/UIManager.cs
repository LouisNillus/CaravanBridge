using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject shopPanel;
    bool isOpen = true;

    [Header("Inventory System")]
    public int itemIndex;
    public List<ItemsTyper> items = new List<ItemsTyper>();
    public Image selectedItemImage;
    public Text selectedItemText;

    // Awake
    private void Awake()
    {
        instance = this;
    }

    // Start
    void Start()
    {
        
    }

    // Update
    void Update()
    {
        NavigateThroughItems();
    }

    public void OpenCloseShop()
    {
        if(isOpen == true)
        {
            shopPanel.SetActive(false);
            isOpen = false;
        }
        else
        {
            shopPanel.SetActive(true);
            isOpen = true;
        }
    }

    public void NavigateThroughItems()
    {
        
        if (Input.mouseScrollDelta.y != 0)
        {
            itemIndex += (int)Input.mouseScrollDelta.y;

            if (itemIndex > items.Count -1)
            {
                itemIndex = 0;
            }
            else if (itemIndex < 0)
            {
                itemIndex = items.Count-1;
            }

            Debug.Log(itemIndex);
            selectedItemImage.sprite = items[itemIndex].sprite;
            selectedItemText.text = items[itemIndex].name;

        }


    }
}
