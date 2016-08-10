[System.Serializable]
public class SwordSlash : BaseAblity {
    public SwordSlash()
    {
        abilityName = "SwordSlash";
        abilityDes = "An Attack with Slightly more Power then the 'Basic Attack'but with a longer cooldown.";
        abilityID = 2;
        abilityPower = 15;
        ManaCost = 0;//TODO
        coolDown = 1.1f;
    }

}
