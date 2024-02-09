using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuOffState : MonoBehaviour
{
    public TextMeshProUGUI menuTextMeshProUGUI;
    void OnEnable()
    {
        menuTextMeshProUGUI.enabled = false;
    }

    void Update()
    {
    }

    private void OnDisable()
    {
    }
}
