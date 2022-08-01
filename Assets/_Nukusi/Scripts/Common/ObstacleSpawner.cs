using Assets._Nukusi.Scripts.Entities.Inanimate;
using System;
using UnityEngine;
using Zenject;

namespace Assets._Nukusi.Scripts.Common
{
    public class ObstacleSpawner : IInitializable, ITickable, IDisposable
    {
        [Inject] private ObstacleFactory obstacleFactory;
        [Inject] private Borders borders;
        [Inject] private ObstacleSpawnerConfig spawnerConfig;

        private float lastSpawnTime;
        private int obstacleCount;

        public void Initialize()
        {
            lastSpawnTime = Time.timeSinceLevelLoad;
            obstacleCount = 0;
        }

        public void Dispose()
        {

        }

        public void Tick()
        {
            var time = Time.timeSinceLevelLoad;
            if (obstacleCount < spawnerConfig.MaxObstacleNumber && 
                time - lastSpawnTime > spawnerConfig.SpawnRate)
            {
                var random = UnityEngine.Random.Range(0, 100);
                var obstacleType = (random > 50) ? 
                    ObstacleType.SoftObstacle : ObstacleType.HardObstacle;

                SpawnObstacle(obstacleType);

                lastSpawnTime = time;
                obstacleCount++;
            }
        }

        private void SpawnObstacle(ObstacleType obstacleType)
        {
            var position = RandomSpawnPoint();
            var softObstacle = obstacleFactory.Create(obstacleType, position);
        }

        public Vector3 RandomSpawnPoint()
        {
            return new Vector3(
                UnityEngine.Random.Range(borders.Min.x * 0.5f, borders.Max.x * 0.5f),
                borders.Max.y, 0f);
        }
    }
}