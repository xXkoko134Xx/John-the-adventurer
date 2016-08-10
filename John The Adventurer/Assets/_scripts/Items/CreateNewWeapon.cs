using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour {

    private BaseWeapon newWeapon;
    private bool Sword;
    private bool Dagger;
    private bool Bow;
    private bool Staff;
    private bool Shield;

    public void CreateWeapon()
    {
        newWeapon = new BaseWeapon();

        //name
        newWeapon.itemName = "Weapon#" + Random.Range(1, 101);
        //des
        newWeapon.itemDes = "This could or could not be a good weapon I Don't know.";
        //id
        newWeapon.ItemId = Random.Range(1, 101);
        //type
        ChooseWeapontpye();
        //stats
        
        
    }

    private void ChooseWeapontpye()
    {
        int RandomTemp = Random.Range(1, 6);
        if(RandomTemp == 1)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
            Sword = true;
        }else if (RandomTemp == 2)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.DAGGER;
            Dagger = true;

        }
        else if(RandomTemp == 3)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
            Bow = true;
        }else if (RandomTemp == 4)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
            Staff = true;
        }
        else if (RandomTemp == 5)
        {
            newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHIELD;
            Shield = true;
        }
        
    }
    private void ChooseWeaponStats()
    {
        if (Sword)
        {
            newWeapon.Attack = Random.Range(1, 101);
            Sword = false;

        }
        else if (Dagger) { 
            newWeapon.Attack = Random.Range(1, 50);
            Dagger = false;
        }
        else if (Bow)
        {
            newWeapon.Attack = Random.Range(1, 151);
            Bow = false;
        }
        else if (Staff)
        {
            newWeapon.MagicAttack = Random.Range(1, 151);
            Staff = false;
        }
        else if (Shield)
        {
            newWeapon.Defence = Random.Range(1, 50);
            Shield = false;
        }
    }
}
