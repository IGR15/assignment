using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29{
public class BasicsScript : MonoBehaviour
{
        void Start()
        {
            var number = 5;
            var text = "Hello, Unity!";
            var isTrue = true;

            string message = number % 2 == 0 ? $"The number {number} is even." : $"The number {number} is odd.";
            Debug.Log(message);

            Debug.Log($"Current Date: {DateTime.Now.ToShortDateString()}");
            Debug.Log($"Current Time: {DateTime.Now.ToShortTimeString()}");
            Debug.Log($"Current Day: {DateTime.Now.DayOfWeek}");
        }
    }
}
