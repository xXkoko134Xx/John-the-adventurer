using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour  {

    private BasePotions newPotion;

    private void CreatePotion()
    {
        newPotion = new BasePotions();
        newPotion.itemName = "potion";
        newPotion.itemDes = "red for health blue for mana";
        newPotion.ItemId = Random.Range(1, 101);
        choosePotion();

    }
    private void choosePotion()
    {
        int temp = Random.Range(1,3);

        if(temp == 1)
        {
            newPotion.potionType = BasePotions.PotionTypes.HEALTH;
        }else if (temp == 2)
        {
            newPotion.potionType = BasePotions.PotionTypes.MANA;
        }
    }
}
