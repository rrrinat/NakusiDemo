using Assets._Nukusi.Scripts.Entities.Inanimate;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Assets._Nukusi.Scripts.Common
{
    public class ObstacleSpawner : IInitializable, ITickable, IDisposable
    {
        [Inject] private ObstacleFactory obstacleFactory;
        [Inject] private Borders borders;

        public void Initialize()
        {

        }

        public void Dispose()
        {

        }

        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpawnObstacle();
            }
        }

        private void SpawnObstacle()
        {
            var position = RandomSpawnPoint();
            var softObstacle = obstacleFactory.Create(ObstacleType.SoftObstacle, position);
        }

        public Vector3 RandomSpawnPoint()
        {
            return new Vector3(
                UnityEngine.Random.Range(borders.Min.x * 0.5f, borders.Max.x * 0.5f),
                borders.Max.y, 0f);
        }
    }
}