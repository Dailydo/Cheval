using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDescription : MonoBehaviour {

    public GameObject _itemName;
    public GameObject _itemDescription;
    public GameObject _itemIcon;


    public void DisplayItemDescription(Item item)
    {
        _itemName.GetComponent<Text>().text = item.name.ToString();
        _itemDescription.GetComponent<Text>().text = item._description;
        _itemIcon.GetComponent<Image>().sprite = item._icon;
    }
}
