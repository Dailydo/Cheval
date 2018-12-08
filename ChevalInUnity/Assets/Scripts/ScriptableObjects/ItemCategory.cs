using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New ItemCategory", menuName = "ItemCategory")]
public class ItemCategory : ScriptableObject
{
    public Character.Bodypart _bodyPart;
    public List<Item> _itemList = new List<Item>();


    // Use this for initialization
    void Start()
    {
        
    }

    public void UpdateItemsProperties()         //Updates the items contained in the category with important properties
    {
        foreach (Item item in _itemList)
            item._bodypart = _bodyPart;
    }
}