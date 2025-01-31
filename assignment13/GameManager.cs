using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {

        Player playerOne = new Player();
        Player playerTwo = new Player();

        playerOne.InitializePlayer("GinoMachino", 50);
        playerTwo.InitializePlayer("LilAggey", 60);

        playerOne.Heal(20);
        playerTwo.Heal(15);

        playerOne.Heal(true);
        playerTwo.Heal(true);

        Player.ShowPlayerCount();
    }
}
