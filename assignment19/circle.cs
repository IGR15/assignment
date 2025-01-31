using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public GameObject[] obj;
    public float circleRadius = 2f;
    public float rotationSpeed = 100f;
    public float orbitSpeed = 1f;

    void Update()
    {


        // float scale = Mathf.PingPong(Time.time, 5) + 1;
        // transform.localScale = new Vector3(transform.localScale.x, scale, transform.localScale.z);

        foreach (GameObject panal in obj)
        {
            float xNew = Mathf.Cos(Time.time * orbitSpeed) * circleRadius;
            float yNew = Mathf.Sin(Time.time * orbitSpeed) * circleRadius;
            transform.localPosition = new Vector3(xNew, yNew, transform.localPosition.z);
            panal.transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
    }
}
