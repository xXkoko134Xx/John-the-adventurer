using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseEquipment : BaseItem
{
    public enum EquipmentTypes
    {
        HELMET,
        CHEST,
        LEGS,
        BOOTS,
        GUANLETS,
        NECK,
        EAR,
        CAPE,
        RING
    }
    private EquipmentTypes equipmentType;
    public EquipmentTypes EquipmentType
    {
        get { return equipmentType; }
        set { equipmentType = value; }
    }

}
