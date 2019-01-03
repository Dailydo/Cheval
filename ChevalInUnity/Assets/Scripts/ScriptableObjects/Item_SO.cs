using UnityEngine;

[CreateAssetMenu(fileName ="New Item", menuName ="Item")]
public class Item_SO : ScriptableObject {

    public Character.Bodypart _bodypart;        //NOTE: make it private at some point

    public string _name;
    public string _description;
    public Sprite _illustration;
    public Sprite _icon;
}
