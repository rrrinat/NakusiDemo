using Assets._Nukusi.Scripts.Physics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Assets._Nukusi.Scripts.Entities.Inanimate
{
    public class BasicObstacle : MonoBehaviour, IObstacle
    {
        [Inject] private PhysicsConfig physicsConfig;

        public Collider2D Collider { get; private set; }
        public Rigidbody2D Rigidbody { get; private set; }

        public Vector3 position
        {
            get { return transform.position; }
            set { transform.position = value; }
        }

        private void Awake()
        {
            Collider = GetComponent<Collider2D>();
            Rigidbody = GetComponent<Rigidbody2D>();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            var collider = collision.collider;

            var unitContactFilter = physicsConfig.UnitFilter;
            var isContactUnit = Physics2D.IsTouching(collider, Collider, unitContactFilter);

            Debug.Log($"isContactUnit {collider.name} {isContactUnit}");
        }
    }
}