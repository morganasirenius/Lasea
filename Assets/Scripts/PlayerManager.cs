using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;

public class PlayerManager : MonoBehaviour
{
    PhotonView PV;
    void Awake()
    {
        PV = GetComponent<PhotonView>();
    }
    // Start is called before the first frame update
    void Start()
    {
        if (PV.IsMine)
        {
            CreateController();
        }
    }

    void CreateController()
    {
        //Instantiate our player controller
        if (PhotonNetwork.IsMasterClient)
        {

            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "LandPlayerController"), new Vector3(8f, 4f, 0f), Quaternion.identity);
            //PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "SeaPlayerController"), Vector3.zero, Quaternion.identity);
        }
        else
        {
            PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "LandPlayerController"), new Vector3(8f, 4f, 0f), Quaternion.identity);
        }
    }
}
