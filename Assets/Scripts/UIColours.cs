using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIColours : MonoBehaviour
{
    public ColoursScriptableObject colours;
    public bool PrimaryColour;
    
    // Start is called before the first frame update
    void Start()
    {
       if (PrimaryColour)
        {
            this.gameObject.GetComponent<Image>().color = colours.primaryColour;
        }
        else
        {
            this.gameObject.GetComponent<Image>().color = colours.secondaryColour;
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
