using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Character : MonoBehaviour {

    #region Singleton

    public static Character instance = null;              

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of Character found.");
            return;
        }

        instance = this;
    }

    #endregion

    public enum Bodypart { None, Head, Chest, Legs };

    public GameObject _head;
    public GameObject _chest;
    public GameObject _legs;

    //Equip the _active item in the character's bodypart slot matching the item's
    public void EquipItem(Item item)
    {
        GameObject characterSlot = GetGameobjectForBodypart(item._bodypart);
        characterSlot.GetComponent<Image>().sprite = item._illustration;
    }

    public GameObject GetGameobjectForBodypart(Bodypart bodypart)
    {
        GameObject result = null;

        switch (bodypart)
        {
            case Bodypart.Head:
                result = _head;
                break;
            case Bodypart.Chest:
                result = _chest;
                break;
            case Bodypart.Legs:
                result = _legs;
                break;
            default:
                Debug.Log("Gameobject unknown for specified bodypart");
                break;
        }

        return result;
    }
}
