using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDescription : MonoBehaviour {

    public GameObject _itemName;
    public GameObject _itemDescription;
    public GameObject _itemIcon;


    public void DisplayItemDescription(Item_SO item)
    {
        _itemName.GetComponent<Text>().text = item._name;
        _itemDescription.GetComponent<Text>().text = item._description;

        if (_itemIcon.GetComponent<Image>().sprite)
            _itemIcon.GetComponent<Image>().sprite = item._icon;
        else
            _itemIcon.GetComponent<Image>().sprite = item._illustration;

    }
}
