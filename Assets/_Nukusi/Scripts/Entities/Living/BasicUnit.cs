using Assets._Nukusi.Scripts.UI;
using Assets._Nukusi.Scripts.VFX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Assets._Nukusi.Scripts.Entities.Living
{
    public class BasicUnit : MonoBehaviour, IUnit
    {
        [SerializeField] private UnitConfig unitConfig;

        [Inject] private BasicParticle.Pool basicParticlePool;
        [Inject] private HealthbarFactory healthbarFactory;
        [Inject] private UIManager uiManager;

        private Healthbar currentHealthbar;

        public Collider2D Collider { get; private set; }

        public Vector3 position
        {
            get { return transform.position; }
            set 
            {
                transform.position = value;
                currentHealthbar.Position = value;
            }
        }

        public float Height
        {
            get { return Collider.bounds.size.y; }
        }

        public float MaxHealth => unitConfig.MaxHealth;

        public float CurrentHealth { get; private set; }

        public bool IsDead => CurrentHealth <= 0f;

        private void Awake()
        {
            Collider = GetComponent<Collider2D>();

            CurrentHealth = MaxHealth;

            currentHealthbar = healthbarFactory.Create(position, uiManager.RectTransform);
        }

        public bool ReceiveDamage(float damage)
        {
            if (IsDead)
            {
                return true;
            }

            CurrentHealth -= damage;

            var ratio = CurrentHealth / MaxHealth;
            currentHealthbar.SetValue(ratio);

            if (CurrentHealth <= 0f)
            {
                Destroy(gameObject);
                Destroy(currentHealthbar.gameObject);

                var explosion = basicParticlePool.Spawn();
                explosion.transform.position = position;

                return true;
            }

            return false;
        }
    }
}