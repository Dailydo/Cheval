using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGrid : MonoBehaviour {

    public GameObject _itemSlot;


    public Item PopulateGrid(Character.Bodypart bodypart)    
    {
        Item result = new Item();

        //Clear current item grid
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        List<Item> itemList = ItemsManager.instance.GetItemsFromBodypart(bodypart);

        bool firstItemReferenced = false;

        foreach (Item item in itemList)
        {
            if (!firstItemReferenced)
            {
                Debug.Log("Item passed: " + item.name.ToString());
                result = item;
                firstItemReferenced = true;
            }
               
            GameObject newItemSlot = Instantiate(_itemSlot, transform);
            newItemSlot.GetComponent<ItemSlot>()._item = item;
            newItemSlot.GetComponent<ItemSlot>()._icon.sprite = item._icon;
        }

        return result;
    }
}
