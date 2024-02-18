using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kle : MonoBehaviour
{
    public float KuleHiz;
    public float silahHiz;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Keypad4))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -KuleHiz);
        }
        if (Input.GetKey(KeyCode.Keypad6))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * KuleHiz);
        }

        if (Input.GetKey(KeyCode.Keypad8))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * -silahHiz);
        }
        if (Input.GetKey(KeyCode.Keypad2))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * silahHiz);
        }


    }
}
