using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodypartButton : MonoBehaviour {

    public Character.Bodypart _bodypart;

    public void OnClicked()
    {
        Inventory.instance.GetComponent<Inventory>().SetStatus(true);
        Inventory.instance.UpdateOnBodypart(_bodypart);
    }
}
