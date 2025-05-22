using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

    internal void TakeDamage(int damageInInflict)
    {
        health -= damageInInflict;
    }
}
