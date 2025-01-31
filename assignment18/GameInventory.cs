using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInventory : MonoBehaviour
{
    void Start()
    {
        Inventory potionsInventory = new Inventory();
        potionsInventory.AddItem("healing potion");
        potionsInventory.AddItem("strength potion");
        

        Inventory elixirsInventory = new Inventory();
        elixirsInventory.AddItem("elixir");
        elixirsInventory.AddItem("dark elixir");

        Inventory combinedInventory = potionsInventory + elixirsInventory;

        combinedInventory.ShowItems();
    }
}
