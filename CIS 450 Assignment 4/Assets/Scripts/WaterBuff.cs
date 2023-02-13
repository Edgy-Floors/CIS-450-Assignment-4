/*
 * EJ Flores
 * WaterBuff.cs
 * Assignment 4
 * This script edits the description of the weapon to add a water buff.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBuff : Decorator
{
    private void OnTriggerEnter(Collider other)
    {
        weapon.type = "water";
        updateDescription();
        gameObject.SetActive(false);
    }
}
