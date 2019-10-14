﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int cost = 100;

    public int GetSoulCost()
    {
        return cost;
    }

    public void AddSouls(int amount)
    {
        FindObjectOfType<SoulDisplay>().AddSouls(amount);
    }
}
