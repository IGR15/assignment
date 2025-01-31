using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35{


public class BuiltInDelegatesExample : MonoBehaviour
{
    void Start()
        {
            // Action delegate
            Action logMessage = () => Debug.Log("Hello from Action delegate!");
            logMessage();

            // Func delegate
            Func<int, int> square = x => x * x;
            Debug.Log($"Square: {square(5)}");

            // Predicate delegate
            Predicate<int> isEven = x => x % 2 == 0;
            Debug.Log($"Is 4 even? {isEven(4)}");
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
