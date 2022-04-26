using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DoSlide : MonoBehaviour
{
    public void Slide()
    {
        transform.DOMoveX(10,2);
    }
}
