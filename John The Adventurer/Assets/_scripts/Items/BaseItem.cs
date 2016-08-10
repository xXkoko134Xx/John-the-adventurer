using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class BaseItem {
    public string itemName { get; set; }
    public string itemDes { get; set; }
    public int ItemId { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int MagicAttack { get; set; }
    public int Strenght { get; set; }
    public int Intellect { get; set; }
    public int Defence { get; set; }
    public int MagicDefence { get; set; }
    public int Luck { get; set; }

    public enum ItemTypes
    {
        EQUIPMENT,
        WEAPON,
        SCROLL,
        POTION,
        CHEST
    }
    public BaseItem() {
    }
    public BaseItem(Dictionary<string, string> itemsDictionary)
    {
        itemName = itemsDictionary["ItemName"];
    }
    private ItemTypes itemTypes;

    public ItemTypes ItemType
    {
        get { return itemTypes; }
        set { itemTypes = value; }
    }
}
