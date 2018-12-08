using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName ="New Item", menuName ="Item")]
public class Item : ScriptableObject {

    public ItemCategory.BodyPart _bodypart;        //NOTE: make it private at some point

    //public string _name;
    public string _description;
    public Sprite _illustration;

}
