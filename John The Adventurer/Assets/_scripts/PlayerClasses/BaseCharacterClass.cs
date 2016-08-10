using UnityEngine;
using System.Collections;

public class BaseCharacterClass {

    public string characterClassName { get; set; }
    public string chararterClassDescription { get; set; }
    //stats
    public int Health { get; set; }
    public int Attack { get; set; }//used for damage calculation
    public int MagicAttack { get; set; }//used for damage calculation
    public int Strenght { get; set; }//Used for the type of gear player can wear
    public int Intellect { get; set; }//Used for the type of gear player can wear
    public int Defence { get; set; }//Used for the type of gear player can wear and damage reduction calculations
    public int MagicDefence { get; set; }// used for damage reduction calculations
    public int Luck { get; set; }//drop rate chances





}
