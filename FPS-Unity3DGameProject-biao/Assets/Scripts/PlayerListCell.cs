using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerListCell : MonoBehaviour
{
    [SerializeField]
    private Text _playerNameText;

    public void SetPlayerName(string playerName)
    {
        _playerNameText.text = playerName;
    }
}
