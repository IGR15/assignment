using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUtils
{

    public static string DescribeItem<T>(T something)
    {
        return $"this item is {something}.";
    }
}


