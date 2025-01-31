using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger2 : MonoBehaviour
{
      void Start()
    {
        Players player = new Players("GinoMachino", 75);
        Enemy enemy = new Enemy("Radagon", 60);

        Debug.Log("Player: " + player.CharacterName + ", Health: " + player.CharacterHealth);
        Debug.Log("Enemy: " + enemy.CharacterName + ", Health: " + enemy.CharacterHealth);

        player.Heal(20); 

        enemy.Attack(player, 30);
    }
}
