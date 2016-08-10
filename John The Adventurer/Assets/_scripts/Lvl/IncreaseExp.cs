using UnityEngine;
using System.Collections;

public static class IncreaseExp{

    private static int xpRewarded;
    private static Lvlup levelUpScript = new Lvlup();

	public static void AddExp()
    {
        xpRewarded = GameInfo.playerLevel * 100;
        GameInfo.currentExp += xpRewarded;
        if(GameInfo.currentExp >= GameInfo.neededExp)
        {
            Lvled();
        }
    }
    private static void Lvled()
    {
        if(GameInfo.currentExp >= GameInfo.neededExp)
        {
            levelUpScript.LevelUpCharacter();
        }
    }
}
