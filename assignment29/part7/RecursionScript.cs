using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class RecursionScript : MonoBehaviour
    {
        int FibonacciRecursive(int n) => n <= 1 ? n : FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);

        int FibonacciIterative(int n)
        {
            if (n <= 1) return n;
            int a = 0, b = 1, result = 0;
            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }
            return result;
        }

        void Start()
        {
            Debug.Log($"Recursive Fibonacci (n=10): {FibonacciRecursive(10)}");
            Debug.Log($"Iterative Fibonacci (n=10): {FibonacciIterative(10)}");
            Debug.Log($"Recursive Fibonacci (n=30): {FibonacciRecursive(30)}");
            Debug.Log($"Iterative Fibonacci (n=30): {FibonacciIterative(30)}");
        }
    }
}