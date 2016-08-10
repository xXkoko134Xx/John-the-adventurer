using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseScroll : BaseItem {

    public enum ScrollTypes
    {
        TELEPORT,
        HOME,
        SUMMON
    }

    private ScrollTypes scrollTypes;

    public ScrollTypes Scrolltype
    {
        get { return scrollTypes; }
        set { scrollTypes = value; }
    }

}
