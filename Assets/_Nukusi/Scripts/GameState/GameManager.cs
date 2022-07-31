using Assets._Nukusi.Scripts.Entities;
using Assets._Nukusi.Scripts.Entities.Inanimate;
using Assets._Nukusi.Scripts.Entities.Living;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Assets._Nukusi.Scripts.GameState
{
    public class GameManager : IInitializable, ITickable, IDisposable
    {
        [Inject] private UnitFactory unitFactory;
        [Inject] private ObstacleFactory obstacleFactory;

        public void Initialize()
        {
            SpawnUnit();
            SpawnObstacles();
        }

        public void Dispose()
        {
            
        }

        public void Tick()
        {
            
        }

        private void SpawnUnit()
        {
            var position = Vector3.up;
            var basicUnit = unitFactory.Create(UnitType.BasicUnit, position);
        }

        private void SpawnObstacles()
        {
            var position = Vector3.up * 10f;
            var softObstacle = obstacleFactory.Create(ObstacleType.SoftObstacle, position);
        }
    }
}