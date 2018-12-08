using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCard : MonoBehaviour {

    public Item _item;

    public Text _name;
    public Text _bodypart;
    public Text _description;
    public Image _illustration;

	// Use this for initialization
	void Start () {
        _name.text = _item.name;
        _bodypart.text = "[" + _item._bodypart.ToString() + "]";
        _description.text = _item._description;
        _illustration.sprite = _item._illustration;
	}

    public void OnClicked()
    {
        Character.instance.AssignItem(_item);
    }

}
