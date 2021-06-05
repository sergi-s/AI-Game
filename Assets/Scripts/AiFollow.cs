using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiFollow : MonoBehaviour
{

    public float MobDistanceRun = 4.0f;

    public GameObject Player;
    public float speed;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);
        // if (distance < MobDistanceRun)
        // {
        transform.LookAt(Player.transform.position);
        transform.Translate(0, 0, speed * Time.deltaTime);
        // }
    }

}
