using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuOffState : MonoBehaviour
{
    public TextMeshProUGUI menuTextMeshProUGUI;
    public AudioLowPassFilter menuLowPassFilter;

    void OnEnable()
    {
        menuTextMeshProUGUI.enabled = false;
        menuLowPassFilter.enabled = false;
    }

    void Update()
    {
    }

    private void OnDisable()
    {
        // Play an enter menu sound
    }
}
