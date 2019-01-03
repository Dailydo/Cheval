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

    public Item_SO _activeItem;        //Item displayed in the Item Description panel


    void Start()
    {
        //CleanInventoryUI();
    }
    
    //Activate the item grid in the UI in case it weren't active
    //IMPROVEMENT NOTE: (?) Check if inactive before activating
    public void SetStatus(bool status)
    {
        gameObject.SetActive(status);
    }

    public void CleanInventoryUI()
    {
        Debug.Log("Cleaning Inventory UI");

    }

    //Clean then populate the item grid for the specified bodypart 
    //IMPROVEMENT NOTE: Repopulate the grid if it current bodypart != from requested one
    public void UpdateOnBodypart(Character.Bodypart bodypart)
    {
        UpdateItemCategory(bodypart);
        _itemGrid.GetComponent<ItemGrid>().PopulateGrid(bodypart);

        _activeItem = ItemsManager.instance.GetItemsFromBodypart(bodypart)[0];
        DisplayItem(_activeItem);
    }

    public void DisplayItem(Item_SO item)
    {
        _activeItem = item;
        UpdateItemDescription(item);
    }

    //Display the bodypart name in the "Item category" part of the UI
    public void UpdateItemCategory(Character.Bodypart bodypart)
    {
        _itemCategoryName.GetComponent<Text>().text = bodypart.ToString().ToUpper();
    }

    public void UpdateItemDescription(Item_SO item)
    {
        _itemDescription.GetComponent<ItemDescription>().DisplayItemDescription(item);
    }

    //Equip the _active item in the character's bodypart slot matching the item's
    public void EquipCurrentItem()
    {
        if (_activeItem)
            Character.instance.EquipItem(_activeItem);
        else
            Debug.Log("No item currently displayed");
    }
}
