using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment35{

public class TestAbstractClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DerivedClassExample example = new DerivedClassExample();
        example.PerformAction();
        example.PrintInfo();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
}
