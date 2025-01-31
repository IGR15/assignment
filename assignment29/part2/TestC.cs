using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class TestC : MonoBehaviour
    {
        void Start()
        {
            CustomObject obj = new CustomObject(1, "ExampleObject");
            print(obj.ToString());
        }
    }
}