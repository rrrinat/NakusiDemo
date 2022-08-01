using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Assets._Nukusi.Scripts.UI
{
    public class ExtendedHealthbarFactory : IFactory<Vector3, RectTransform, Healthbar>
    {
        private readonly DiContainer container;

        public ExtendedHealthbarFactory(DiContainer container)
        {
            this.container = container;
        }

        public Healthbar Create(Vector3 position, RectTransform holder)
        {
            var prefab = Resources.Load<GameObject>($"Prefabs/UI/Healthbar");
            var healthbar = container.InstantiatePrefabForComponent<Healthbar>(prefab);

            var rectTransform = healthbar.GetComponent<RectTransform>();
            rectTransform.SetParent(holder);

            healthbar.Position = position;

            return healthbar;
        }
    }
}