using Assets._Nukusi.Scripts.Entities.Living;
using System;
using UnityEngine;
using Zenject;

namespace Assets._Nukusi.Scripts.Common
{
    public class UnitSpawner : IInitializable, ITickable, IDisposable
    {
        [Inject] private UnitFactory unitFactory;
        [Inject] private Borders borders;

        public void Initialize()
        {

        }

        public void Dispose()
        {

        }

        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                SpawnUnit();
            }
        }

        private void SpawnUnit()
        {
            var position = Vector3.up * 1f;
            var basicUnit = unitFactory.Create(UnitType.BasicUnit, position);

            var yPosition = borders.Min.y + basicUnit.Height / 2;
            var spawnPosition = new Vector3(
                UnityEngine.Random.Range(borders.Min.x * 0.5f, borders.Max.x * 0.5f),
                yPosition, 0f);

            basicUnit.position = spawnPosition;
        }
    }
}