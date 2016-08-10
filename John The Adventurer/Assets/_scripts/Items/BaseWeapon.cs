using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseWeapon : BaseItem
{

	public enum WeaponTypes
    {
      SWORD,
      DAGGER,
      BOW,
      STAFF,
      SHIELD

    }
    private WeaponTypes weaponType;
    

    public WeaponTypes WeaponType
    {
        get { return weaponType; }
        set { weaponType = value; }
    }
    
}
