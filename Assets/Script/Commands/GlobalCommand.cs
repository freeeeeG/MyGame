using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;

public class GameStartCommand : AbstractCommand<GameStartCommand>
{
    protected override GameStartCommand OnExecute()
    {
        Debug.Log("GameStartCommand");
        return this;
    }
}
