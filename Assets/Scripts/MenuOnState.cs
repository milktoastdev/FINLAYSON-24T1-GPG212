using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuOnState : MonoBehaviour
{
    public TextMeshProUGUI menuTextMeshProUGUI;
    public AudioLowPassFilter menuLowPassFilter;
    void OnEnable()
    {
        menuTextMeshProUGUI.enabled = true;
        menuLowPassFilter.enabled = true;
    }

    void Update()
    {
    }

    private void OnDisable()
    {
        // Cut menu music
        
        // Play an exit menu sound
    }
}
