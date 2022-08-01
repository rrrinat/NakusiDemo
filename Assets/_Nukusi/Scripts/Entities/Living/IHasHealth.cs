using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Nukusi.Scripts.Entities.Living
{
    public interface IHasHealth
    {
        float MaxHealth { get; }
        float CurrentHealth { get; }
        bool IsDead { get; }

        bool ReceiveDamage(float damage);
    }
}