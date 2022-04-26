using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginQuiz : MonoBehaviour
{

    public GameObject mainCanvas;
    public GameObject quizPanel;

    public void Begin()
    {
        mainCanvas.GetComponent<HideAllPanels>().HidePanels();
        quizPanel.GetComponent<PanelScript>().Show();
    }
}
