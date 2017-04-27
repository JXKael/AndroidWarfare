using System;
using UnityEngine;

[Serializable]
public class GameStatus
{
    public string gameName;
    public string version;
    public bool isStereo;
    public bool isUseHardWare;
    public Refencenes[] statusList = new Refencenes[4];
}
