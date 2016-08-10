using UnityEngine;
using System.Collections;

public class CreateNewCharacter : MonoBehaviour {
    private BasePlayer newPlayer;
    private bool isMageClass;
    private bool isWarriorClass;
    public Canvas PickAClass;
    public Canvas Name;
    public Input nameBox;

    void Start()
    {
        
        PickAClass = PickAClass.GetComponent<Canvas>();
        Name = Name.GetComponent<Canvas>();
        Name.enabled = false;
    }
    
	public void mage()
    {
        newPlayer = new BasePlayer();
        newPlayer.playerClass = new BaseMageClass();
        SetUp();
        PickAClass.enabled = false;
        Name.enabled = true;

    }
    public void warrior()
    {
        newPlayer = new BasePlayer();
        newPlayer.playerClass = new BaseWarriorClass();
        SetUp();
        PickAClass.enabled = false;
        Name.enabled = true;
    }
    public void SetUp()
    {
        newPlayer.playerLevel = 1;
        newPlayer.Health = newPlayer.playerClass.Health;
        newPlayer.Attack = newPlayer.playerClass.Attack;
        newPlayer.MagicAttack = newPlayer.playerClass.MagicAttack;
        newPlayer.Strenght = newPlayer.playerClass.Strenght;
        newPlayer.Defence = newPlayer.playerClass.Defence;
        newPlayer.MagicDefence = newPlayer.playerClass.MagicDefence;
        newPlayer.Luck = newPlayer.playerClass.Luck;
        StoreNewPlayerInfo();
        SaveInformation.SaveAllInformation();
    }
    public void ChangeName(string PlayerName)
    {
        newPlayer.playerName = PlayerName;
        Debug.Log(newPlayer.playerName);
    }
    private void StoreNewPlayerInfo()
    {
        GameInfo.playerName = newPlayer.playerName;
        GameInfo.playerLevel = newPlayer.playerLevel;
        GameInfo.Health = newPlayer.Health;
        GameInfo.Attack = newPlayer.Attack;
        GameInfo.MagicAttack = newPlayer.MagicAttack;
        GameInfo.Strenght = newPlayer.Strenght;
        GameInfo.Defence = newPlayer.Defence;
        GameInfo.MagicDefence = newPlayer.MagicDefence;
        GameInfo.Luck = newPlayer.Luck;
    }
}
