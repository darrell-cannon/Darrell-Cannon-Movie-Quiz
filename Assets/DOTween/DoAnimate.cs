using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public static class DoAnimate
{
    public static void Correct(Transform transform)
    {
        transform.DOScale(new Vector3(1.3f, 1.3f, 0), 0.3f).SetLoops(2, LoopType.Yoyo);
        
    }

    public static void Incorrect(Transform transform)
    {
        transform.DOShakePosition(0.4f, 10);
    }

    public static void SlideOutAndIn(Transform transform, int location)
    {      
        Vector3 OGpos = transform.position;
        transform.DOMoveX(location, 0.3f).SetLoops(2, LoopType.Yoyo);
    }
}
