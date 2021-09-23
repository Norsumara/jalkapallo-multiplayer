using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;

public class CreateAndJoinRoom : MonoBehaviourPunCallbacks
{
    public TMP_InputField createInput;

    public TMP_InputField joinInput;


    public void CreateRoom()
    {
        //T‰ll‰ k‰skyll‰ luodaan serverille uusi huone
        PhotonNetwork.CreateRoom(createInput.text);

    }
    
    public void JoinRoom()
    {
        //Yhdist‰‰ valmiiksi nimettyyn pelihuoneeseen
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Game");
            
    }
}
