using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;

public class RpgItemDataBase : MonoBehaviour {
    public TextAsset ItemInventory;
    public static List<BaseItem> itemInventory = new List<BaseItem>();
    private List<Dictionary<string, string>> inventoryItemsDictionary = new List<Dictionary<string, string>>();
    private Dictionary<string, string> inventoryDictionary;

    void Awake()
    {
        Readitems();
        for(int i=0; i < inventoryItemsDictionary.Count; i++)
        {
            itemInventory.Add(new BaseItem(inventoryItemsDictionary[i]));
        }
    }

    public void Readitems()
    {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(ItemInventory.text);
        XmlNodeList itemList = xmlDocument.GetElementsByTagName("Item");

        foreach(XmlNode itemInfo in itemList)
        {
            XmlNodeList itemContent = itemInfo.ChildNodes;

            inventoryDictionary = new Dictionary<string, string>();


                  foreach (XmlNode content in itemContent)
                   {
                switch (content.Name){
                    case "itemName":
                        inventoryDictionary.Add("itemName", content.InnerText);
                        break;

                    case "ItemId":
                        inventoryDictionary.Add("ItemId", content.InnerText);
                        break;

                    case "ItemType":
                        inventoryDictionary.Add("ItemType", content.InnerText);
                        break;


                }

            }
            inventoryItemsDictionary.Add(inventoryDictionary);
        }
    }
}
