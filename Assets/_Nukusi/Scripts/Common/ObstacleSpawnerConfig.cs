using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Nukusi.Scripts.Common
{
    [CreateAssetMenu(menuName = "Nakusi/Common/Obstacle Spawner Config")]
    public class ObstacleSpawnerConfig : ScriptableObject
    {
        [SerializeField] private float maxObstacleNumber;
        public float MaxObstacleNumber => maxObstacleNumber;

        [SerializeField] private float spawnRate;
        public float SpawnRate => spawnRate;
    }
}