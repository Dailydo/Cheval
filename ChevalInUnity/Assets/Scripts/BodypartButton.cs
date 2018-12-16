using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodypartButton : MonoBehaviour {

    public Character.Bodypart _bodypart;

    public void OnClicked()
    {
        Inventory.instance.UpdateOnBodypart(_bodypart);
    }
}
