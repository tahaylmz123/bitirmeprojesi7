using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject TankSilah;
    public Vector3 Offset = new Vector3(0f, 3.987f, 5f);
    
   
    // Update is called once per frame
    void LateUpdate()
    {
        
        transform.rotation = TankSilah.transform.rotation ;
    }
}
