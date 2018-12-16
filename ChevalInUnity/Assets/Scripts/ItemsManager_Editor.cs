using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ItemsManager))]
public class ItemsManager_Editor : Editor {

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        ItemsManager _itemManager = (ItemsManager)target;

        if (GUILayout.Button("Reference button"))
        {
            Debug.Log("Reference button clicked.");
        }
    }

}
