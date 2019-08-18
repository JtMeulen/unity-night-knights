﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f,5f)] [SerializeField] float movementSpeed = 1f;

    private void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * movementSpeed);
    }
}
