using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New ItemCategory", menuName = "ItemCategory")]
public class ItemCategory_SO: ScriptableObject
{
    public Character.Bodypart _bodyPart;
    public List<Item_SO> _itemList = new List<Item_SO>();
}