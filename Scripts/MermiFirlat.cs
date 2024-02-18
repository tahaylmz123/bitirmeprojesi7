using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiFirlat : MonoBehaviour
{
    public GameObject mermi;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(mermi, transform.position,transform.rotation);
        }
    }

}
