using UnityEngine;
using System.Collections;

[System.Serializable]
public class BasePotions : BaseItem
{

	public enum PotionTypes
    {
        HEALTH,
        MANA
    }
    private PotionTypes PotionType;

    public PotionTypes potionType
    {
        get { return potionType; }
        set { potionType = value; }
    }
}
