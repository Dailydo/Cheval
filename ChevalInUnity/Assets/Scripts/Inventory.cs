using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

    #region Singleton

    public static Inventory instance = null;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Inventory found.");
            return;
        }

        instance = this;
    }

    #endregion

    public GameObject _itemCategoryName;
    public GameObject _itemDescription;
    public GameObject _itemGrid;

    public Item _activeItem;        //Item displayed in the Item Description panel


    void Start()
    {
        CleanInventoryUI();
    }
    
    public void CleanInventoryUI()
    {
        Debug.Log("Cleaning Inventory UI");

    }

    public void UpdateOnBodypart(Character.Bodypart bodypart)
    {
        UpdateItemCategory(bodypart);
        _activeItem = _itemGrid.GetComponent<ItemGrid>().PopulateGrid(bodypart);
        DisplayItem(_activeItem);
    }

    public void DisplayItem(Item item)
    {
        _activeItem = item;
        UpdateItemDescription(item);
    }

    public void UpdateItemCategory(Character.Bodypart bodypart)
    {
        _itemCategoryName.GetComponent<Text>().text = bodypart.ToString().ToUpper();
    }

    public void UpdateItemDescription(Item item)
    {
        _itemDescription.GetComponent<ItemDescription>().DisplayItemDescription(item);
    }

    public void EquipCurrentItem()
    {
        if (_activeItem)
            Character.instance.EquipItem(_activeItem);
        else
            Debug.Log("No item currently displayed");
    }
}
