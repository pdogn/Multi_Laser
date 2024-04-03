using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class RoomManager : MonoBehaviourPunCallbacks
{
    public GameObject player;
    public Transform spawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        //PhotonNetwork.ConnectUsingSettings();
        SpawnPlayer();
    }

    //public override void OnConnectedToMaster()
    //{
    //    base.OnConnectedToMaster();

    //    Debug.Log("Connected to sever");
    //    PhotonNetwork.JoinLobby();
    //}

    //public override void OnJoinedLobby()
    //{
    //    base.OnJoinedLobby();

    //    Debug.Log("We're in the lobby");
    //    PhotonNetwork.JoinOrCreateRoom("test", null, null);
    //}

    //public override void OnJoinedRoom()
    //{
    //    base.OnJoinedRoom();

    //    Debug.Log("We're in a room now");

    //    GameObject _player = PhotonNetwork.Instantiate(player.name, spawnPoint.position, Quaternion.identity);
    //    _player.GetComponent<PlayerSetup>().IsLocalPlayer();
    //}

    void SpawnPlayer()
    {
        GameObject _player = PhotonNetwork.Instantiate(player.name, spawnPoint.position, Quaternion.identity);
        _player.GetComponent<PlayerSetup>().IsLocalPlayer();
    }
}
