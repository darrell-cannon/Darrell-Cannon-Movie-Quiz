using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EndGameImages : MonoBehaviour
{
    public GameObject mainCanvas;
    public GameObject winImageButton;
    public GameObject loseImageButton;

    public void Win(int score)
    {
        for (int i = 0; i < score; i++)
        {
            SpawnImages(winImageButton);
        }              
    }

    public void Lose()
    {
        SpawnImages(loseImageButton);
    }

     void SpawnImages(GameObject image)
    {
        GameObject currentImage = Instantiate(image);
        currentImage.transform.SetParent(mainCanvas.transform, false);
        currentImage.transform.SetPositionAndRotation(new Vector3(Random.Range(90, 1000), Random.Range(2000, 3000), 0), Quaternion.Euler(new Vector3(0, 0, Random.Range(0,360))));
        currentImage.transform.DOMoveY(-300, Random.Range(6,10));
        int rotation = 180;
        if (Random.Range(0,2) == 0)
        {
            rotation = -rotation;
        }
        currentImage.transform.DORotate(new Vector3(0, 0, rotation), 12);
    }
}
