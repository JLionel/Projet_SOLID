using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSOInitializer : OrdonedMonoBehaviour
{
    [SerializeField] private List<LevelData> _levelDatas;
    public override void DoAwake()
    {
        foreach (var LevelData in _levelDatas)
        {
            LevelData.Init();
        }
    }
    public override void DoUpdate()
    {

    }
}
