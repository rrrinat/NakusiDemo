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
        [Inject] private Healthbar.Factory healthbarFactory;
        [Inject] private UIManager uiManager;

        private Healthbar currentHealthbar;

        public Collider2D Collider { get; private set; }

        public Vector3 position
        {
            get { return this.transform.position; }
            set { this.transform.position = value; }
        }

        public float MaxHealth => unitConfig.MaxHealth;

        public float CurrentHealth { get; private set; }

        public bool IsDead => CurrentHealth <= 0f;

        private void Awake()
        {
            Collider = GetComponent<Collider2D>();

            CurrentHealth = MaxHealth;

            currentHealthbar = healthbarFactory.Create();
            currentHealthbar.RectTransform.SetParent(uiManager.RectTransform);
            currentHealthbar.Position = position;
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
                
                var explosion = basicParticlePool.Spawn();
                explosion.transform.position = position;

                return true;
            }

            return false;
        }
    }
}