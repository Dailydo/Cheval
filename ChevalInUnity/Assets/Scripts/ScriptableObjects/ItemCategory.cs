using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New ItemCategory", menuName = "ItemCategory")]
public class ItemCategory : ScriptableObject
{
    public enum BodyPart {None, Head, Chest, Legs};

    public BodyPart _bodyPart;
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