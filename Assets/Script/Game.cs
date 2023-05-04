using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
public class Game : Architecture<Game>
{
    protected override void Init()
    {
        Debug.Log("Game Init");
    }
}
