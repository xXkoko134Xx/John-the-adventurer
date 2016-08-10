using UnityEngine;
using System.Collections;

public class GameInfo : MonoBehaviour {
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    public static BaseEquipment EquipmentOne {get; set;}
	public static string playerName { get; set; }
    public static int playerLevel { get; set; }
    public static BaseCharacterClass playerClass { get; set; }
    public static int Health { get; set; }
    public static int Attack { get; set; }
    public static int MagicAttack { get; set; }
    public static int Strenght { get; set; }
    public static int Defence { get; set; }
    public static int MagicDefence { get; set; }
    public static int Luck { get; set; }
    public static int currentExp { get; set; }
    public static int neededExp { get; set; }
}
