using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

namespace Com.Kawalisun.SimpleHostile
{
    public class Manager : MonoBehaviourPunCallbacks
    {
        public string player_prefab;
        public Transform spawn_point;

        private void Start()
        {
            Spawn();
        }

        private void Spawn()
        {
            PhotonNetwork.Instantiate(player_prefab, spawn_point.position,spawn_point.rotation);
        }

    }

}
