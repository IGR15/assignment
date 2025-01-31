using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class Officer : Character
    {
        public Officer(string name, int health, Position position) : base(name, health, position) { }
        public Officer() : this("No name", 100, new Position(0, 0, 0)) { }

        public override void DisplayInfo()
        {
            Debug.Log("officer");
            base.DisplayInfo();
        }
    }

}