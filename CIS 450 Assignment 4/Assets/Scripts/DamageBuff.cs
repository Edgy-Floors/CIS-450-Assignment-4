/*
 * EJ Flores
 * DamageBuff.cs
 * Assignment 4
 * This script adds an amount to the player's weapon damage and updates the UI.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBuff : Decorator
{
    private void OnTriggerEnter(Collider other)
    {
        weapon.damage += 10;
        updateDamage();
        gameObject.SetActive(false);
    }
}
