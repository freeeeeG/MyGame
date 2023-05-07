using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
public class GMCommandBase : MonoBehaviour, IController
{
    public IArchitecture GetArchitecture()
    {
        return Game.Interface;
    }
}
