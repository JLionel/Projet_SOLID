using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Player/PlayerNames")]
public class PlayerNames : PlayerData
{
    public List<string> Names = new List<string>();

    public override void Init()
    {
        Names = new List<string>();
    }

    public void SetSize(int Size)
    {
        Names = new List<string>(Size);
    }

    public override void AddNew()
    {
        Names.Add("");
    }

    public void AddNew(string Name)
    {
        Names.Add(Name);
    }

    public int GetPlayerCount()
    {
        return Names.Count;
    }
}

