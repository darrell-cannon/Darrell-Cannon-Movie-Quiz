using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PanelScript : MonoBehaviour, IToggleable
{
    public void Show()
    {
        this.gameObject.SetActive(true);
        this.transform.localScale = new Vector3(0, 0, 1);
        this.transform.DOScale(1, 0.4f);
    }

    public void Hide()
    {
        
        this.transform.DOScale(0, 0.3f).OnComplete(SetInactive);
    }

    void SetInactive()
    {
        gameObject.SetActive(false);
    }
}
