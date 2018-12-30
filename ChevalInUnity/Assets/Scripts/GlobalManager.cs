using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalManager : MonoBehaviour {

    #region Singleton

    public static GlobalManager instance = null;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("More than one instance of GameManager found.");
            return;
        }

        instance = this;
    }

    #endregion

    // Use this for initialization
    void Start () {
        SetInventoryStatus(false);
	}
	
    public void SetInventoryStatus(bool status)     //Status true to activate, false to deactivate
    {
        Inventory.instance.GetComponent<Inventory>().SetStatus(false);
    }
}
