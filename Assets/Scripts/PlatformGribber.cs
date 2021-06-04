using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject theLedge;
    public GameObject theplayer;
    void Start()
    {
        theplayer.transform.parent = theLedge.transform;
    }


    void Update()
    {
        theplayer.transform.parent = null;
    }
}
