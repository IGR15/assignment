using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : Character
{

    // public Players(string name, int health){
    //     this.name = name;
    //     this.health = health;

    // } Wrong way to inherit from a class
    public Players(string name, int health) : base(name, health) { } //correct way to inherit from a class using base :))


    public void Heal(int amount)
    {
        CharacterHealth += amount;
        Debug.Log("Player heald " + amount + "\n" + "health: " + CharacterHealth);
    }
}
