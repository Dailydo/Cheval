using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Item _item;
    public Image _icon;

    public void OnClicked()
    {
        if (_item)
        {
            Inventory.instance.DisplayItem(_item);
        }
        else
            Debug.Log("No item assigned to the clicked item slot");
    }
}
