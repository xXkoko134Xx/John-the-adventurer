using UnityEngine;
using System.Collections;

public class BattleStateStart {



    private BasePlayer newEnemy = new BasePlayer();
    private StatCalculations statcalculations = new StatCalculations();
    private BaseCharacterClass[] classTypes = new BaseCharacterClass[] { new BaseWarriorClass(), new BaseMageClass() };
    private string[] enemeyNames = new string[] { "deadly enemy", "slightly Tougher enemy", "that one annoying guy at your work", "You should run kinda of enemy" };
 

    public void prepBattle()
    {
        createEnemy();
    }



    private void createEnemy()
    {
        newEnemy.playerName = enemeyNames[Random.Range(0, enemeyNames.Length + 1)];
        newEnemy.playerLevel = Random.Range(GameInfo.playerLevel - 2, GameInfo.playerLevel + 2);
        newEnemy.playerClass = classTypes[Random.Range(0, classTypes.Length + 1)];
        newEnemy.Health = statcalculations.CalculateStat(newEnemy.Health, StatCalculations.StatType.HP, newEnemy.playerLevel, true);
        newEnemy.Attack = statcalculations.CalculateStat(newEnemy.Attack, StatCalculations.StatType.ATTACK, newEnemy.playerLevel, true);
        newEnemy.Defence = statcalculations.CalculateStat(newEnemy.Defence, StatCalculations.StatType.DEFENCE, newEnemy.playerLevel, true);
        newEnemy.MagicAttack = statcalculations.CalculateStat(newEnemy.MagicAttack, StatCalculations.StatType.MAGIC, newEnemy.playerLevel, true);
        newEnemy.MagicDefence = statcalculations.CalculateStat(newEnemy.MagicDefence, StatCalculations.StatType.MAGICDEFENCE, newEnemy.playerLevel, true);
        newEnemy.Luck = statcalculations.CalculateStat(newEnemy.Luck, StatCalculations.StatType.LUCK, newEnemy.playerLevel, true);

    }

    private void FistMove()
    {
        if (GameInfo.Luck >= newEnemy.Luck)
        {
            CombatSateMachine.CurrentState = CombatSateMachine.BattleStates.PLAYERTURN;
        }
        else
        {
            CombatSateMachine.CurrentState = CombatSateMachine.BattleStates.ENEMYTURN;
        }

    }
    



}
