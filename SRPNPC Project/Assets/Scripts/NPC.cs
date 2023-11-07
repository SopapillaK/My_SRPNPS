using System;
using UnityEngine;

public class NPC : MonoBehaviour
{
    internal void TakeDamage(int amount)
    {
        GetComponent<Health>().TakeDamage(amount);
    }
}