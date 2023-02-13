/*
 * EJ Flores
 * Weapon.cs
 * Assignment 4
 * This script acts as the base weapon for decorators to add to it.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour, IWeapon
{
    public UnityEngine.UI.Text txt;
    public UnityEngine.UI.Text txt2;
    public float damage;
    public string type = "none";


    private void Start()
    {
        updateDescription();
        updateDamage();
    }

    public void updateDescription()
    {
        txt.text = "Weapon type: " + type;
    }

    public void updateDamage()
    {
        txt2.text = "Weapon damage: " + damage;
    }
}
