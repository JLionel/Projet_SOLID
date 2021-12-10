﻿using UnityEngine;

namespace Script.CommandPattern
{
    [CreateAssetMenu (menuName = "GameCommand/PlayerCommand/Move")]
    public class MovePlayerCommand : PlayerCommand
    {
        public DirectionMove _direction;
        
        
        public override void Execute(string playerName)
        {
            /*PlayerMove player = CatchPlayer(playerName);
            player.Move(VectorDirectionMove.FetchDirection(_direction));*/
            
            TwitchChatConnected.Instance.WriteMessage($"Move {_direction.ToString()}");
        }

        private PlayerMove CatchPlayer(string playerName)
        {
            //TODO catch playerMove with his name
            return new PlayerMove();
        }
    }
}