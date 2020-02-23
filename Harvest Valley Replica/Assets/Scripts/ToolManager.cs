using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolManager : MonoBehaviour
{
    public Tool[] tools;
    public ToolManagerUI toolManagerUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EnableTool(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EnableTool(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            EnableTool(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            EnableTool(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            EnableTool(4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            DisableAllTools();
        }
    }

    private void EnableTool(int index)
    {
        if (tools[index] == null)
        {
            return;
        }

        DisableAllTools();
        tools[index].enabled = true;
        toolManagerUI.ChangeToolName(tools[index].name);
    }

    private void DisableAllTools()
    {
        for (int i = 0; i < tools.Length; i++)
        {
            if (tools[i] != null)
            {
                tools[i].enabled = false;
            }
        }
    }
}
