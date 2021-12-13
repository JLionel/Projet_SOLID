using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class Lobby : MonoBehaviour
{
    [SerializeField] private PlayerNames playerNames;
    [SerializeField] private TextMeshProUGUI subtitleText;
    [SerializeField] private TextMeshProUGUI listText;

    private int _myInt = 0;

    private void Update()
    {
        UpdateList();
    }

    public void UpdateList()
    {
        listText.text += playerNames.Names.Last() + TextLayout();
        subtitleText.text = playerNames.Names.Count + " players connected";
    }

    private string TextLayout()
    {
        string myString = "";

        switch (_myInt)
        {
            case 0:
                myString = "\t\t\t";
                break;
            case 1:
                myString = "\t\t\t";
                break;
            case 2:
                myString = "\n";
                break;
        }

        _myInt += 1;
        if (_myInt >= 3) _myInt = 0;
        
        return myString;
    }
}
