using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Nukusi.Scripts.Common
{
    [CreateAssetMenu(menuName = "Nakusi/Common/Unit Spawner Config")]
    public class UnitSpawnerConfig : ScriptableObject
    {
        [SerializeField] private float maxUnitNumber;
        public float MaxUnitNumber => maxUnitNumber;

        [SerializeField] private float spawnRate;
        public float SpawnRate => spawnRate;
    }
}