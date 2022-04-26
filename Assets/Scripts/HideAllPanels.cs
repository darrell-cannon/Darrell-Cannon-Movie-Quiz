using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HideAllPanels : MonoBehaviour
{
    public void HidePanels()
    {
        foreach(IToggleable panel in GetComponentsInChildren<IToggleable>())
        {
            panel.Hide();            
        }

    }
}
