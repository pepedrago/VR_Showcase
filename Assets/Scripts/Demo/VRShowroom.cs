﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRControlls.Templates;
using VRControlls.Navigation;

namespace VRControlls.Demo
{
    public class VRShowroom : MonoBehaviour
    {

        public GameObject PlayerStartPosition;
        public GameObject NavigationWaypoint;
        private GameObject m_player;

        void Awake()
        {
            m_player = GameObject.FindGameObjectWithTag("Player");
            m_player.transform.position = PlayerStartPosition.transform.position;
            NavigationWaypoint.SetActive(false);
        }

        void Start()
        {
            GameFSM.Instance.Gamestate = GameFSM.GAMESTATES.INTRO;
            m_player.GetComponent<AutoTransport>().MoveAlongWayPoints(0, IntroFinished);
            Waypoints.Instance.WaypointsEnabled = false;
        }

        private void IntroFinished()
        {
            Waypoints.Instance.WaypointsEnabled = true;
            NavigationWaypoint.SetActive(true);
            NavigationWaypoint.GetComponent<Waypoint>().MoveTo();
        }

    }
}

