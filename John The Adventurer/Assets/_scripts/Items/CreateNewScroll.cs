using UnityEngine;
using System.Collections;

[System.Serializable]
public class CreateNewScroll : MonoBehaviour {

    private BaseScroll newScroll;
    private void CreateScroll()
    {
        newScroll = new BaseScroll();
        newScroll.itemName = "Scroll";
        newScroll.ItemId = Random.Range(1, 101);
        newScroll.itemDes = "Scroll of Scrolly Scroll.";
        GrabScrollType();
    }
    private void GrabScrollType()
    {
        int temp = Random.Range(1, 4);
        switch (temp)
        {
            case 1:
                newScroll.Scrolltype = BaseScroll.ScrollTypes.HOME;
                break;
            case 2:
                newScroll.Scrolltype = BaseScroll.ScrollTypes.SUMMON;
                break;
            case 3:
                newScroll.Scrolltype = BaseScroll.ScrollTypes.TELEPORT;
                break;
        }
            
    }
}
