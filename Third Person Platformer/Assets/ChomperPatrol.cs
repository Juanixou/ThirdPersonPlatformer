using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChomperPatrol : MonoBehaviour
{
    public Transform wayPoint1;
    public Transform wayPoint2;
    private Transform actualWayPoint;


    // Start is called before the first frame update
    void Start()
    {
        actualWayPoint = wayPoint2;
    }

    public void ChangeWaypoint()
    {
        if(actualWayPoint == wayPoint2)
        {
            actualWayPoint = wayPoint1;
        }
        else
        {
            actualWayPoint = wayPoint2;
        }

        this.transform.LookAt(actualWayPoint.transform);

    }
}
