using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment27
{
    public class CallByValueAndReference : MonoBehaviour
    {
        void Start()
        {

            int a = 5;
            int b = 10;

            Debug.Log($"Before CallByValue method: a = {a}");
            CallByValue(a);
            Debug.Log($"After: a = {a}");

            Debug.Log($"Before  CallByReference method: a = {b}");
            CallByReference(ref b);
            Debug.Log($"After: a = {b}");

            int c;
            Outmethod(out c);
            Debug.Log($"After UseOutKeyword: c = {c}");
        }

        void CallByValue(int number)
        {
            number += 10;
            Debug.Log($"Inside CallByValue method: number = {number}");
        }

        void CallByReference(ref int number)
        {
            number += 10;
            Debug.Log($"Inside CallByReference method: number = {number}");
        }

        void Outmethod(out int number)
        {
            number = 20;
            Debug.Log($"Inside UseOutKeyword method: number = {number}");
        }
        void Update()
        {

        }
    }
}
