using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float speed;
    public float Horizontal;
    public float vertical;
    public float rotateHiz;
  

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Rotate(Vector3.right * rotateHiz * Time.deltaTime*vertical);
        transform.Rotate(Vector3.forward * rotateHiz * Time.deltaTime*-Horizontal);
        
    }
}
