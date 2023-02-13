/*
 * EJ Flores
 * Decoratr.cs
 * Assignment 4
 * This script is the abstract class for the decorators/buffs.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Decorator : MonoBehaviour, IWeapon
{
    public Weapon weapon;

    private void Start()
    {
        weapon = GameObject.FindGameObjectWithTag("player").GetComponent<Weapon>();
        Debug.Log(weapon);
    }

    public virtual void updateDescription()
    {
        weapon.updateDescription();
    }

    public virtual void updateDamage()
    {
        weapon.updateDamage();
    }
}
