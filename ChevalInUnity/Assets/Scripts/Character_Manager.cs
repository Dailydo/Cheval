using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_Manager : MonoBehaviour {

    public Inventory _inventory;

    public GameObject _head;
    public GameObject _chest;
    public GameObject _legs;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update (){

    }

    public void AssignItem (GameObject button)
    {
        button.GetComponent<ButtonItemInfo>()._bodyPart.GetComponent<SpriteRenderer>().sprite = button.GetComponent<ButtonItemInfo>()._ItemSprite;
    }
}
