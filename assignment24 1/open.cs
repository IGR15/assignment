// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class open : MonoBehaviour
// {
//     // Start is called before the first frame update
//     public GameObject[] obj;
//     public float rotationSpeed = 90f;



//     // Update is called once per frame
//     void Update()
//     {
//         float rotation = 0f;
//         float scale = Mathf.PingPong(Time.time, 5) + 1;
//         print(rotation);
        
       
//             foreach (GameObject panal in obj)
//             {

//                 panal.transform.Rotate(Vector3.up, rotation);
//             }
            
        
//         // float zNew = Mathf.Sin(Time.time);
//         // transform.rotation = Quaternion.Euler(new Vector3(0, 0, zNew * 360f));
//         // transform.Rotate(Vector3.one, rotationSpeed * Time.deltaTime);
//     }
// }
