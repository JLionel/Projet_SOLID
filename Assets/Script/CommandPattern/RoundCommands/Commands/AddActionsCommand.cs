using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "GameCommand/RoundCommand/AddAction")]
public class AddActionsCommand : RoundCommand
{
    public override void Execute(string playerName, PlayerCommand playerCommand)
    {
        if (GameStateManager.Instance.GameState.StatesName == StatesName.WaitTurnActions)
            RoundCommandHistory.Instance.AddCommand(playerName, playerCommand);
        
    }
}