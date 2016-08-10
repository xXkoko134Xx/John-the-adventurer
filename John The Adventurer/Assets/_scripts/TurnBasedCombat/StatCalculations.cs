using UnityEngine;
using System.Collections;

public class StatCalculations : MonoBehaviour {

    private float enemyHpModifier = 0.5f;
    private float enemyAttackModifier = 0.25f;
    private float enemyMagicAttackModifier = 0.25f;
    private float enemyDefenceModifier = 0.25f;
    private float enemyMagicDefenceModifier = 0.25f;
    private float enemyLuckModifier = .25f;
    private float statModifer;

    public enum StatType
    {
        HP,
        ATTACK,
        MAGIC,
        DEFENCE,
        MAGICDEFENCE,
        LUCK
    }
    public int CalculateStat(int statval, StatType statType, int level,bool isEnemy)
    {
        if (isEnemy)
        {
            SetModifier(statType);
            return (statval + (int)((statval * statModifer) * level));
        }
        return 0;

    }

    private void SetModifier( StatType statType)
    {
        
        if(statType == StatType.HP)
        {
            statModifer = enemyHpModifier;
          
        }
        if (statType == StatType.ATTACK)
        {
            statModifer = enemyAttackModifier;
            
        }
        if (statType == StatType.MAGIC)
        {
            statModifer = enemyMagicAttackModifier;

        }
        if (statType == StatType.DEFENCE)
        {
            statModifer = enemyDefenceModifier;
        }
        if (statType == StatType.MAGICDEFENCE)
        {
            statModifer = enemyMagicDefenceModifier;
        }
        if (statType == StatType.LUCK)
        {
            statModifer = enemyLuckModifier;
        }


    }
   
}
