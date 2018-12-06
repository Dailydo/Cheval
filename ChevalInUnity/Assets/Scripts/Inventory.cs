using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Inventory", order = 1)]
public class Inventory : ScriptableObject
{
    public List<Item> _itemList = new List<Item>();
}

[System.Serializable]
public struct Item
{
    public string _itemName;
    public Sprite _itemImage;
}