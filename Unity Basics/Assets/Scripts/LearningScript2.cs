using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.0f;
    public float distance = 0.0f;
    public float time = 0.0f;
    public float maxSpeedLimit = 70.0f;
    public float minSpeedLimit = 40.0f;
    void Start()
        {
        speed = distance / time;
        if (float.IsNaN(speed))
            {
            print("The time value is 0 !!!");
            }
            else
            {
            if (speed > maxSpeedLimit)
            {
            print("You are exceeding the speed limit!");
            }
            else if (speed < minSpeedLimit)
            {
            print("You are not going fast enough!");
            }
            else if (speed == maxSpeedLimit || speed == minSpeedLimit)
            {
            print("You are close to breaking the law!");
            }
            else
            {
            print("You are within the speed limit!");
            }
            print("You are traveling at " + speed + " MPH.");
            }
        }
        // Update is called once per frame
        void Update()
        {
        }
        }

