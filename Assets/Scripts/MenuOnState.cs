using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuOnState : MonoBehaviour
{
    public TextMeshProUGUI menuTextMeshProUGUI;
    void OnEnable()
    {
        menuTextMeshProUGUI.enabled = true;
    }

    void Update()
    {
    }

    private void OnDisable()
    {
    }
}
