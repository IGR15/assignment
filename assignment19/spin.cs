using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
     public GameObject[] obj;
    public float rotationSpeed = 100f;

    // Update is called once per frame
    void Update()
    {
         foreach (GameObject panal in obj){
            panal.transform.Rotate(Vector3.one, rotationSpeed * Time.deltaTime);
         }
        // float zNew = Mathf.Sin(Time.time);
        // transform.rotation = Quaternion.Euler(new Vector3(0, 0, zNew * 360f));
        transform.Rotate(Vector3.one, rotationSpeed * Time.deltaTime);
    }
}
