﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_coin : MonoBehaviour
{
    public Vector3 movementSpeed;
    public Space space;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementSpeed * Time.deltaTime, space);
    }
}