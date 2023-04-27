using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Singleton<Player>
{
    public string playerName;
    public int level;
    public int MaxMoney;
    public int CurrentMoney;
    public int skillPoint;
}
