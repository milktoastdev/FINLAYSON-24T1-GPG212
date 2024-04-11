using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TMP_InputField playerNameInputField;

    public delegate void SimpleDelegateUIEvent();
    public event SimpleDelegateUIEvent playerNameInput;

    public void PlayerNameInput()
    {
        playerNameInput?.Invoke();
    }
}
