﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneCamera : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PlayerPosition = player.transform.position;
        transform.position = new Vector3(PlayerPosition.x+3, PlayerPosition.y+3,-1);
    }
}
