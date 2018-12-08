using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour {

    public static Character instance = null;              //Static instance of GameManager which allows it to be accessed by any other script

    public enum Bodypart { None, Head, Chest, Legs };

    [System.Serializable]       
    public struct CharacterItem     //A reference to the item currently equiped and the gameobject containing its image on the character
    {
        public Item _item;
        public GameObject _characterGameobject;
    }

    public CharacterItem _head;
    public CharacterItem _chest;
    public CharacterItem _legs;


    void Awake()
    {
        if (instance == null)       //Check if instance already exists            
            instance = this;        //if not, set instance to this
        else if (instance != this)      //If instance already exists and it's not this:
            Destroy(gameObject);    //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a Character_Manager
        //DontDestroyOnLoad(gameObject);            
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update (){

    }

    //Assigns item as current item for the embed bodypart
    public void AssignItem (Item item)
    {
        CharacterItem itemDef = GetBodypartGameobject(item._bodypart);
        itemDef._item = item;
        itemDef._characterGameobject.GetComponent<Image>().sprite = item._illustration;
    }

    //Returns the CharacterItem in the character that matches the passed bodypart
    CharacterItem GetBodypartGameobject(Bodypart bodypart)
    {
        CharacterItem result = new CharacterItem();

        switch(bodypart)
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
                Debug.Log("Unknown bodypart, unable to return a matching gameobject in Character.");
                break;
        }

        return result;
    }
}
