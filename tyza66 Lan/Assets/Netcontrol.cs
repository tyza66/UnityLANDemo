using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class Netcontrol : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (isLocalPlayer) { 
            GetComponent<Move>().enabled = true; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
