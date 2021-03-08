using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
public class PlayerListItem : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_Text nameText;
    Player player;
    public void SetUp(Player _player)
    {
        player =_player;
        nameText.text = _player.NickName;
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.Log("OnPlayerLeftRoom");
        if (player == otherPlayer)
        {
            Destroy(gameObject);
        }
        
    }
    
    public override void OnLeftRoom()
    {
        Debug.Log("OnLeftRoom");
        Destroy(gameObject);
    }
}
