using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingUi : MonoBehaviour, ISlideable
{
    public void Slide()
    {
        DoAnimate.SlideOutAndIn(this.transform, 2000);
    }
}
