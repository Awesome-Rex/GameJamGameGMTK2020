﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;

[RequireComponent(typeof(Controllable))]
public class Aimable : MonoBehaviour
{
    public Vector3 mousePosition;
    
    public Vector3 direction
    {
        get
        {
            return (Input.mousePosition) - Camera.main.WorldToScreenPoint(transform.position);
        }
    }

    void FixedUpdate()
    {
        if (GetComponent<Controllable>().inControl)
        {
            transform.forward = direction;
        }
    }
}