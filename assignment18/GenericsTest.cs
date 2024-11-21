using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericsTest : MonoBehaviour
{
    void Start()
    {
        GameContainer<string> potionContainer = new GameContainer<string>();
        potionContainer.SetItem("healing Potion");
        Debug.Log($"stored item: {potionContainer.GetItem()}");
        string description = GameUtils.DescribeItem(potionContainer.GetItem());
        Debug.Log(description);
    }
}
