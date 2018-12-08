using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsManager : MonoBehaviour {

    public List<ItemCategory> _itemCategories = new List<ItemCategory>();


    // Use this for initialization
    void Start()
    {
        
    }

    public void UpdateItemCategoryProperties()          
    {
        foreach (ItemCategory itemCategory in _itemCategories)
            itemCategory.UpdateItemsProperties();
    }
}
