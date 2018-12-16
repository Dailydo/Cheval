using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsManager : MonoBehaviour {

    #region Singleton

    public static ItemsManager instance = null;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of ItemsManager found.");
            return;
        }

        instance = this;
    }

    #endregion

    public ItemCategory _headCategory;
    public ItemCategory _chestCategory;
    public ItemCategory _legsCategory;


    //Returns a list of items for a specific bodypart
    public List<Item> GetItemsFromBodypart(Character.Bodypart bodypart)
    {
        List<Item> result = new List<Item>();

        switch (bodypart)
        {
            case Character.Bodypart.Head:
                result = _headCategory._itemList;
                break;
            case Character.Bodypart.Chest:
                result = _chestCategory._itemList;
                break;
            case Character.Bodypart.Legs:
                result = _legsCategory._itemList;
                break;
            default:
                Debug.Log("Unknown bodypart");
                break;
        }

        return result;
    }

}
