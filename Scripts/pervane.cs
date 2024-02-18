using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pervane : MonoBehaviour
{
    public float speed = 5000f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
    }
}
