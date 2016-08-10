using UnityEngine;
using System.Collections;

public class CreateNewEquipment : MonoBehaviour {
    private BaseEquipment newEquipment;
    private string [] itemNames = new string[4] { "common", "Greater", "Amazing","insane" };
    

    public void CreateEquipment()
    {
        newEquipment = new BaseEquipment();
        newEquipment.itemName = itemNames[Random.Range(0, 5)];
        newEquipment.ItemId = Random.Range(0, 101);
        ChooseItemType();
        newEquipment.itemDes = "such item much damage";
        newEquipment.Attack = Random.Range(1, 11);
        newEquipment.Defence = Random.Range(1, 11);
        newEquipment.Health = Random.Range(1, 11);
        newEquipment.Intellect = Random.Range(1, 11);
        newEquipment.MagicAttack = Random.Range(1, 11);
        newEquipment.Luck = Random.Range(1, 11);
        newEquipment.Strenght = Random.Range(1, 11);
        newEquipment.MagicDefence = Random.Range(1, 11);
    }
    private void ChooseItemType()
    {
        int RandomTemp = Random.Range(0, 10);
        switch (RandomTemp)
        {
            case 1:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HELMET;
                break;
            case 2:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;
                break;
            case 3:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
                break;
            case 4:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.BOOTS;
                break;
            case 5:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.GUANLETS;
                break;
            case 6:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.NECK;
                break;
            case 7:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.EAR;
                break;
            case 8:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CAPE;
                break;
            case 9:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RING;
                break;
        }
    }
	
}
