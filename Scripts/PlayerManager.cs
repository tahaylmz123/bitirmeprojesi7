using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float healt;
    public bool dead = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void getDamage(float damage)
    {
        if ( healt-damage>=0)
        {
            healt -= damage;
        }
        else
        {
            healt = 0;
        }
        amIdeads();
    }
    void amIdeads()
    {
        if(healt==0)
        {
            dead = true;
        }
    }
}
