using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/// <summary>
/// <para>Draws editor buttons for testing save/load functions.</para>
/// <para>This isn't an editor window because it's only applicable to one component.</para>
/// <para>Editor for child classes is false because there will be no child classes.</para>
/// </summary>
[CustomEditor(typeof(SaveManager), false)]
public class SaveManager_Editor : Editor
{
    /// <summary>
    /// <para>Draws the editor in the inspector.</para>
    /// <para>Making it an override void allows us to customise our editor.</para>
    /// </summary>
    public override void OnInspectorGUI()
    {
        // Draws the default editor in the inspector.
        base.OnInspectorGUI();
        
        // Begins laying out buttons horizontally.
        GUILayout.BeginHorizontal();
        
        if (GUILayout.Button("Save"))
        {
            // 'target' is a magical word that tells the editor where to find the original component so you can access it's functions.
            
            /*
            SaveManager saveManager;
            saveManager = target as SaveManager;
            saveManager?.SavePlayerPrefs();
            */
            
            // Cleaner line using shortcuts.
            (target as SaveManager)?.SavePlayerPrefs();
        }

        if (GUILayout.Button("Load"))
        {
            /*
            SaveManager saveManager;
            saveManager = target as SaveManager;
            saveManager?.LoadPlayerPrefs();
            */
            
            // Cleaner line using shortcuts.
            (target as SaveManager)?.LoadPlayerPrefs();
        }
        
        // Ends laying out buttons horizontally.
        GUILayout.EndHorizontal();
    }
}