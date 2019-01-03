using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "New Dialog", menuName = "Dialog")]
public class Dialog_SO : ScriptableObject
{
    public string _title;
    public List<string> _body;
}
