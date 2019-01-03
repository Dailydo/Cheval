using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Item_SO _item;
    public Image _icon;

    public void OnClicked()
    {
        if (_item)
        {
            Inventory.instance.DisplayItem(_item);
            Inventory.instance.EquipCurrentItem();
        }
        else
            Debug.Log("No item assigned to the clicked item slot");
    }
}
