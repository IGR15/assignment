using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        void OnEnable() => print("GameObject Enabled");
        void OnDisable() => print("GameObject Disabled");
        void Start()
        {
            print("Game started!");

            GameObject target = GameObject.Find("TargetObject");
            print(target != null ? $"Found object by name: {target.name}" : "No TargetObject found.");

            GameObject joker = GameObject.FindGameObjectWithTag("Joker");
            print(joker != null ? $"Found object by tag: {joker.name}" : "No Joker object found.");

            Light light = FindObjectOfType<Light>();
            print(light != null ? $"Found object of type Light: {light.name}" : "No Light object found.");
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                GameObject target = GameObject.Find("TargetObject");
                if (target != null)
                {
                    target.SetActive(false);
                    print("TargetObject deactivated!");
                }
            }
        }
    }
}
