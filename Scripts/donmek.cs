using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donmek : MonoBehaviour
{
    public float rote;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rote * Time.deltaTime);
    }
}
