using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System.Linq;
using TMPro;
public class Launcher : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_InputField roomNameInputField;
    [SerializeField] TMP_InputField usernameInputField;
    [SerializeField] TMP_Text errorText;
    [SerializeField] TMP_Text roomNameText;
    [SerializeField] GameObject playerListItemPrefab;
    [SerializeField] Transform playerListContent;
    [SerializeField] GameObject startGameButton;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master");
        PhotonNetwork.JoinLobby();
        //automatically loads scene for everyone in the room, not just the host
        PhotonNetwork.AutomaticallySyncScene = true;   
    }

    public override void OnJoinedLobby()
    {
        Debug.Log("Joined Lobby");
        MenuManager.Instance.OpenMenu("Title");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void CreateRoom()
    {
        //If you don't pass in a string, it will randomly craete one.
        //Prob something i want to do since i want people to join by code
        if (string.IsNullOrEmpty(roomNameInputField.text) || string.IsNullOrEmpty(usernameInputField.text)){
            return;
        }
        PhotonNetwork.CreateRoom(roomNameInputField.text);
        PhotonNetwork.NickName = usernameInputField.text;
        MenuManager.Instance.OpenMenu("Loading");
    }

    public void JoinRoom(string roomName)
    {
        PhotonNetwork.JoinRoom(roomName);
        MenuManager.Instance.OpenMenu("Loading");
    }

    public void JoinRoom()
    {
        if (string.IsNullOrEmpty(roomNameInputField.text) || string.IsNullOrEmpty(usernameInputField.text)){
            return;
        }
        PhotonNetwork.JoinRoom(roomNameInputField.text);
        PhotonNetwork.NickName = usernameInputField.text;
        MenuManager.Instance.OpenMenu("Loading");
    }
    public override void OnJoinedRoom()
    {
        Debug.Log("Joining Room");
        roomNameText.text = PhotonNetwork.CurrentRoom.Name;
        MenuManager.Instance.OpenMenu("Room");
        Player[] players = PhotonNetwork.PlayerList;

        foreach(Transform child in playerListContent)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0; i < players.Count(); i++)
        {
            Instantiate(playerListItemPrefab, playerListContent).GetComponent<PlayerListItem>().SetUp(players[i]);
        }

        startGameButton.SetActive(PhotonNetwork.IsMasterClient);
    }
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log("Join Room Failed");
        errorText.text = "Join Room Failed: " + message;
        MenuManager.Instance.OpenMenu("Error");
    }

    public override void OnMasterClientSwitched(Player newMasterClient)
    {
        startGameButton.SetActive(PhotonNetwork.IsMasterClient);
    }
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Room Creation Failed");
        errorText.text = "Room Creation Failed: " + message;
        MenuManager.Instance.OpenMenu("Error");
    }

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
        MenuManager.Instance.OpenMenu("Loading");
    }

    public override void OnLeftRoom()
    {
        Debug.Log("leaving room in Laucner");
        MenuManager.Instance.OpenMenu("Title");
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Instantiate(playerListItemPrefab, playerListContent).GetComponent<PlayerListItem>().SetUp(newPlayer);
    }

    public void StartGame()
    {
        PhotonNetwork.LoadLevel(1);
    }

}