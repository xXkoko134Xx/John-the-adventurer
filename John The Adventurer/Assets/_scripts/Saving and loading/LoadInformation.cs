using UnityEngine;
using System.Collections;

public class LoadInformation{

public static void LoadAllInformation()
    {
        GameInfo.playerName = PlayerPrefs.GetString("PLAYERNAME");
        GameInfo.playerLevel = PlayerPrefs.GetInt("PLAYERLEVEL");
        GameInfo.Health = PlayerPrefs.GetInt("PLAYERHEALTH");
        GameInfo.Attack = PlayerPrefs.GetInt("PLAYERATTACK");
        GameInfo.MagicAttack = PlayerPrefs.GetInt("PLAYERMAGICATTACK");
        GameInfo.Strenght = PlayerPrefs.GetInt("PLAYERSTRENGHT");
        GameInfo.Defence = PlayerPrefs.GetInt("PLAYERDEFENCE");
        GameInfo.MagicDefence = PlayerPrefs.GetInt("PLAYERMAGICDEFENCE");
        GameInfo.Luck = PlayerPrefs.GetInt("PLAYERLUCK");
        if(PlayerPrefs.GetString("EQIUPMENT1") != null)
        {
            GameInfo.EquipmentOne = (BaseEquipment) PPSerialization.Load("EQIUPMENT1");
        }
    }
}
