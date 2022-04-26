using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoBounce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOScale(1.1f, 0.8f).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
