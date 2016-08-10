using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseMageClass : BaseCharacterClass {
    

        public BaseMageClass()
    {
        characterClassName = "Mage";
        chararterClassDescription = "A Weak yet cunning type class, not the Strongest person in the world";
        //stats
        Health = 100;
        Attack = 5;
        MagicAttack = 12;
        Strenght = 10;
        Intellect = 15;
        Defence = 8;
        MagicDefence = 12;
        Luck = 0;
    }
}
