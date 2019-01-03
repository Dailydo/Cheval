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

    public GameObject _dialog;


    // Use this for initialization
    void Start () {
        _dialog.SetActive(true);        //Make this a list for all key gameobjects to be activated?

        if (!Dialog.instance._skipEntryDialog)
            Dialog.instance.Appear();
        else
            Dialog.instance.Disappear();

        Inventory.instance.UpdateOnBodypart(Character.Bodypart.Head);
	}
	
    public void SetInventoryStatus(bool status)     //Status true to activate, false to deactivate
    {
        Inventory.instance.GetComponent<Inventory>().SetStatus(false);
    }
}
