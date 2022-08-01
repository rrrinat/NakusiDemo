using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Nukusi.Scripts.Entities.Inanimate
{
    [CreateAssetMenu(menuName = "Nakusi/Entities/Obstacle Config")]
    public class ObstacleConfig : ScriptableObject
    {
        [SerializeField] private float minDamage = 10f;
        public float MinDamage => minDamage;

        [SerializeField] private float maxDamage = 20f;
        public float MaxDamage => maxDamage;

    }
}