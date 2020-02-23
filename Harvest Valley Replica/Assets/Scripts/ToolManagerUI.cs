using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToolManagerUI : MonoBehaviour
{
    public TextMeshProUGUI toolNameText;

    public void ChangeToolName(string toolName)
    {
        toolNameText.text = toolName;
    }
}
