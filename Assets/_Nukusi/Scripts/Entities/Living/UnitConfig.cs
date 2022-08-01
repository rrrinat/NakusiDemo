using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Nukusi.Scripts.Entities.Living
{
    [CreateAssetMenu(menuName = "Nakusi/Entities/Unit Config")]
    public class UnitConfig : ScriptableObject
    {
        [SerializeField] private float maxHealth;
        public float MaxHealth => maxHealth;


    }
}