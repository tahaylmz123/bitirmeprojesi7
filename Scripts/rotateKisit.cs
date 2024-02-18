using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateKisit : MonoBehaviour
{
    public float kisitz;
    public float kisitx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        roteKisit();
    }
    void roteKisit()
    {
        if (transform.rotation.x < -kisitx)
        {
            transform.position = new Vector3(-kisitx, transform.rotation.y, transform.rotation.z);
        }

        if (transform.rotation.x < kisitx)
        {
            transform.position = new Vector3(kisitx, transform.rotation.y, transform.rotation.z);
        }

        if (transform.rotation.x < -kisitz)
        {
            transform.position = new Vector3(transform.rotation.x, transform.rotation.y, -kisitz);
        }

        if (transform.rotation.x < kisitz)
        {
            transform.position = new Vector3(transform.rotation.x, transform.rotation.y, kisitz);
        }
    }

}
