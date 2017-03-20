using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeComponent : MonoBehaviour, IMeleeComponent
{
    [Header("Exposed Variables")]
    [SerializeField]
    float attackSpeed;
    [SerializeField]
    float damage;
    [SerializeField]
    int cost;


    #region Properties
    public float AttackSpeed
    {
        get
        {
            return attackSpeed;
        }
    }

    public float Damage
    {
        get
        {
            return damage;
        }
    }

    public int Cost
    {
        get
        {
            return cost;
        }
    }

    public string Name { get; set; }
    #endregion

    public virtual void Attack(Vector3 direction)
    {
        // Needs implementation of Attack
        Debug.Log("Normal Attack: " + direction.ToString());
    }

    public virtual void Initialize(int points)
    {
        // Melee Component Logic here
        points -= cost;
        damage = points / 5;
        attackSpeed = points / 10;
    }

    public override string ToString()
    {
        return "Stick";
    }
}
