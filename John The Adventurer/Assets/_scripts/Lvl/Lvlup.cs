using UnityEngine;
using System.Collections;

public class Lvlup{
    public int maxPlayerLvl = 65;

public void LevelUpCharacter()
    {

        if (GameInfo.currentExp > GameInfo.neededExp)
        {
            GameInfo.currentExp -= GameInfo.neededExp;
        }else
        {
            GameInfo.currentExp = 0;
        }
        if(GameInfo.playerLevel> maxPlayerLvl)
        {
            GameInfo.playerLevel++;
        }
        








        DetermineExpForlvl();

    }
    private void DetermineExpForlvl()
    {
        int temp = (GameInfo.playerLevel * 1000) + 250;
        GameInfo.neededExp = temp;
    }
}
