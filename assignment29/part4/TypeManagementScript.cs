using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{

    public class typeManagementScript : MonoBehaviour
    {
        void Start()
        {
            Animal animal = new Cat();
            animal.MakeSound();
            animal.Move();

            Cat cat = animal as Cat;
            if (cat != null)
            {
                cat.MakeSound();
                cat.Move();
            }

            List<ICanFight> fighters = new List<ICanFight> { new Cat(), new Warrior() };
            foreach (var fighter in fighters)
            {
                fighter.Attack();
                Debug.Log(fighter is Cat ? "The object is a Cat." : "The object is a Warrior.");
            }
        }
    }
}

