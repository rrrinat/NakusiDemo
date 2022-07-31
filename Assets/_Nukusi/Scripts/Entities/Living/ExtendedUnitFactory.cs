using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Assets._Nukusi.Scripts.Entities.Living
{
    public class ExtendedUnitFactory : IFactory<UnitType, Vector3, IUnit>
    {
        private readonly DiContainer container;

        public ExtendedUnitFactory(DiContainer container)
        {
            this.container = container;
        }

        public IUnit Create(UnitType unitType, Vector3 position)
        {
            var prefab = Resources.Load<GameObject>($"Prefabs/Units/{unitType}");
            var unit = container.InstantiatePrefabForComponent<IUnit>(prefab);
            unit.position = position;

            return unit;
        }
    }
}