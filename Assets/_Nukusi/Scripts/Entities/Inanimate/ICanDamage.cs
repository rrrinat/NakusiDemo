using Assets._Nukusi.Scripts.Entities.Living;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Nukusi.Scripts.Entities.Inanimate
{
    public interface ICanDamage
    {
        float CurrentDamage { get; }
        void Attack(IUnit unit);
    }
}