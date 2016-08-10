[System.Serializable]
public class AttackAbility : BaseAblity {
    public AttackAbility()
    {
        abilityName = "Attack";
        abilityDes = "Basic Attack with a short cooldown.";
        abilityID = 1;
        abilityPower = 10;
        ManaCost = 0;
        coolDown = 0.1f;
    }
	
}
