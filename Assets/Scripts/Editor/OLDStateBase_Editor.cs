using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(StateBase),true)]
public class OLDStateBase_Editor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        //GUILayout.BeginHorizontal();

        if (GUILayout.Button(GetType().Name + " : Toggle"))
        {
            //(target as StateBase)?.GetComponent<StateManager>().ChangeState();
        }
        
        //GUILayout.Space(1);
        
        //GUILayout.EndHorizontal();
    }
}