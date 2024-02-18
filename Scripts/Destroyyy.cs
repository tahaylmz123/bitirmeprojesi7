using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyyy : MonoBehaviour
{
    public float boundsZ=700;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z> boundsZ)
        {
            Destroy(gameObject);
        }
    }
}
