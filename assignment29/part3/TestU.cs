using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class TestU : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(Utilities.Add(1, 2, 3, 4, 5));

            string repeated = "Hello".RepeatString(3);
            Debug.Log(repeated);
        }
    }
}
