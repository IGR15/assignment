using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
            Character soldier = new Soldier();
            Character officer = new Officer("amin", 100, new Position(15, 5, 10));// :)

            Character[] characters = { soldier, officer };

            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].DisplayInfo();
            }


            Debug.Log("before attack:");
            soldier.DisplayInfo();

            officer.Attack(30, soldier, "shooting");

            Debug.Log("after attack:");
            soldier.DisplayInfo();
        }
    }
}
