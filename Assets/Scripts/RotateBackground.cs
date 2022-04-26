using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBackground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.rotation = Quaternion.Euler(0, 0, Random.Range(-30,30));
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(0, 0, 0.7f) * Time.deltaTime);
    }
}
