using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGrid : MonoBehaviour {

    public GameObject _itemSlot;

    //Clear the item grid from its item slots and create add new ones, fed from the itemCategory list matching the requested bodypart
    public void PopulateGrid(Character.Bodypart bodypart)    
    {
        Item result = ScriptableObject.CreateInstance<Item>();

        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        List<Item> itemList = ItemsManager.instance.GetItemsFromBodypart(bodypart);

        foreach (Item item in itemList)
        {  
            GameObject newItemSlot = Instantiate(_itemSlot, transform);
            newItemSlot.GetComponent<ItemSlot>()._item = item;

            if (item._icon)     //if the item (data) contains an icon, use it as icon in the item slot, else use the item illustration
                newItemSlot.GetComponent<ItemSlot>()._icon.sprite = item._icon;
            else
                newItemSlot.GetComponent<ItemSlot>()._icon.sprite = item._illustration;
        }
    }
}
