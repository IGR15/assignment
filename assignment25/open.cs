using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open : MonoBehaviour
{
    public GameObject[] obj;
    public GameObject[] diorama;
    public float rotationDuration = 3f;
    private float elapsedTime = 0f;
    private bool isRotating = true;



    void Update()
    {
        if (isRotating)
        {

            elapsedTime += Time.deltaTime;


            float rotationStep = (180f / rotationDuration) * Time.deltaTime;


            foreach (GameObject panel in obj)
            {
                panel.transform.Rotate(Vector3.up, rotationStep);
            }



            float scaleFactor = elapsedTime / rotationDuration;


            foreach (GameObject dio in diorama)
            {
                dio.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, scaleFactor);
            }
            if (elapsedTime >= rotationDuration)
            {
                isRotating = false;
                foreach (GameObject dio in diorama)
                {
                    dio.transform.localScale = Vector3.one;
                }
            }
        }


    }
    // // Start is called before the first frame update
    // public GameObject[] obj;
    // public float rotationSpeed = 90f;



    // // Update is called once per frame
    // void Update()
    // {
    //     float rotation = 0f;
    //     float scale = Mathf.PingPong(Time.time, 5) + 1;
    //     print(rotation);


    //     foreach (GameObject panal in obj)
    //     {
    //         float variable = rotationSpeed * Time.deltaTime;
    //         print(variable);

    //         panal.transform.Rotate(Vector3.up, variable);
    //     }


    //     // float zNew = Mathf.Sin(Time.time);
    //     // transform.rotation = Quaternion.Euler(new Vector3(0, 0, zNew * 360f));
    //     // transform.Rotate(Vector3.one, rotationSpeed * Time.deltaTime);
    // }
}
