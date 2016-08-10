using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseWarriorClass : BaseCharacterClass
{

    public BaseWarriorClass()
    {
        characterClassName = "Warrior";
        chararterClassDescription = "Strong Fighting type class, not the brightest person in the world";
        //stats
        Health = 150;
        Attack = 12;
        MagicAttack = 0;
        Strenght = 10;
        Intellect = 2;
        Defence = 10;
        MagicDefence = 10;
        Luck = 0;


    }
}
