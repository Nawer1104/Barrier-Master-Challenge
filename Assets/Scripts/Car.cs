using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    

    public float speed = 2;

    int index = 0;

    public bool isLoop = true;

    private void Update()
    {
        Vector3 destination = Trap.Instance.waypoints[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = newPos;

        float distance = Vector3.Distance(transform.position, destination);
        if (distance <= 0.05)
        {
            if (index < Trap.Instance.waypoints.Count - 1)
            {
                index++;
            } 
            else
            {
                if (isLoop)
                {
                    index = 0;
                }
            }
        }
    }
}
