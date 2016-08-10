using UnityEngine;
using System.Collections;

[System.Serializable]
public class BasePlayer  {

    public string playerName { get; set; }
    public int playerLevel { get; set; }
    public BaseCharacterClass playerClass { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int MagicAttack { get; set; }
    public int Strenght { get; set; }
    public int Defence { get; set; }
    public int MagicDefence { get; set; }
    public int Luck { get; set; }
    public int currentExp { get; set; }
    public int neededExp { get; set; }
}
