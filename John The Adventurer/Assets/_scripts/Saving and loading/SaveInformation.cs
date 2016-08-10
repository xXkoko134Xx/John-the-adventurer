using UnityEngine;
using System.Collections;

public class SaveInformation : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
	public static void SaveAllInformation()
    {
        PlayerPrefs.SetInt("PLAYERLEVEL",GameInfo.playerLevel);
        PlayerPrefs.SetString("PLAYERNAME", GameInfo.playerName);
        PlayerPrefs.SetInt("PLAYEREALTH", GameInfo.Health);
        PlayerPrefs.SetInt("PLAYERATTACK", GameInfo.Attack);
        PlayerPrefs.SetInt("PLAYERMAGICATTACK", GameInfo.MagicAttack);
        PlayerPrefs.SetInt("PLAYERSTRENGHT", GameInfo.Strenght);
        PlayerPrefs.SetInt("PLAYERDEFENCE", GameInfo.Defence);
        PlayerPrefs.SetInt("PLAYERMAGICDEFENCE", GameInfo.MagicDefence);
        PlayerPrefs.SetInt("PLAYERLUCK", GameInfo.Luck);

        if (GameInfo.EquipmentOne != null)
        {
            PPSerialization.save("EQUPMENT1", GameInfo.EquipmentOne);
        }

    }
}
