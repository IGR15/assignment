using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public string playerName;
    public int health;
    public static int playerCount = 0;


    public void InitializePlayer(string name, int initialHealth)
    {
        playerName = name;
        health = initialHealth;
        playerCount++;

        Debug.Log("Player initialized:\n " + "player Name:" + playerName + "\n" + "health: " + health);
    }

    public void Heal(int amount)
    {
        health += amount;
        Debug.Log("Player " + playerName + " heald " + amount + "\n" + "health: " + health);
    }


    public void Heal(bool fullRestore)
    {
        if (fullRestore)
        {

            health = 100;
            Debug.Log("Player: " + playerName + " restord his full health" + health);
        }
    }


    public static void ShowPlayerCount()
    {
        Debug.Log("Current number of players: " + playerCount);
    }
}
