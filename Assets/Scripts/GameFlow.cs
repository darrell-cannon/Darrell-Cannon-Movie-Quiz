using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    public GameObject mainCanvas;

    public GameObject mainMenuPanel;
    public GameObject quizPanel;
    public GameObject leaderBoardPanel;
    public GameObject gameEndPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCanvas.GetComponent<HideAllPanels>().HidePanels();
        mainMenuPanel.GetComponent<PanelScript>().Show();
    }

    public void ShowPanel(string panelName)
    {
        mainCanvas.GetComponent<HideAllPanels>().HidePanels();
        switch (panelName)
        {
            case "mainMenuPanel":
                mainMenuPanel.GetComponent<PanelScript>().Show();
                return;
            case "quizPanel":
                quizPanel.GetComponent<PanelScript>().Show();
                return;
            case "gameEndPanel":
                gameEndPanel.GetComponent<PanelScript>().Show();
                return;
            case "leaderBoardPanel":
                leaderBoardPanel.GetComponent<PanelScript>().Show();
                return;

            default:
                print($"Incorrect name: {panelName}");
                return;
        }
    }

    
}
