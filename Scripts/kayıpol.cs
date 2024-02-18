using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kayıpol : MonoBehaviour
{
    public float zBounds;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z>zBounds)
        {
            Destroy(gameObject);
        }
    }
}
