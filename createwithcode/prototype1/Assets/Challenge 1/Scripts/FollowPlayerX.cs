﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(25, 4, 3);


    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
