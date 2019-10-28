using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckArrival : MonoBehaviour
{


    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Chomper")
        {
            other.GetComponent<ChomperPatrol>().SendMessage("ChangeWaypoint");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Chomper")
        {

        }
    }

}
