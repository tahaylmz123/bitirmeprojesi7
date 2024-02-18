using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermi : MonoBehaviour
{
    public float hiz;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * hiz * Time.deltaTime);
    }
}
