using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelToggle : MonoBehaviour
{
    private bool isOn = false;
    [SerializeField]
    private GameObject InformationPanel;

    public void onToggleButton()
    {
        InformationPanel.SetActive(!isOn);
        isOn = !isOn;
    }
    
}
