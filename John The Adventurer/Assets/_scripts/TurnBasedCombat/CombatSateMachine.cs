using UnityEngine;
using System.Collections;

public class CombatSateMachine : MonoBehaviour {

    private bool ExpGiven = false;

    public enum BattleStates
    {
        START,
        PLAYERTURN,
        ENEMYTURN,
        CALDAMAGE,
        LOSE,
        WIN
    }
    public static BattleStates CurrentState{ set; get;}




	// Use this for initialization
	void Start () {

        CurrentState = BattleStates.START;
	
	}
	
	// Update is called once per frame
	void Update () {
        switch (CurrentState)
        {
            case (BattleStates.START):

                break;
            case (BattleStates.PLAYERTURN):

                break;
            case (BattleStates.ENEMYTURN):

                break;

           case(BattleStates.CALDAMAGE):

                break;


            case (BattleStates.LOSE):

                break;
            case (BattleStates.WIN):
                if (!ExpGiven)
                {
                    IncreaseExp.AddExp();
                    ExpGiven = true;
                }
                break;
        }
	
	}
    
}
