using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Assets._Nukusi.Scripts.Entities.Living
{
    public class BasicUnit : MonoBehaviour, IUnit
    {
        public Collider2D Collider { get; private set; }

        public Vector3 position
        {
            get { return this.transform.position; }
            set { this.transform.position = value; }
        }

        private void Awake()
        {
            Collider = GetComponent<Collider2D>();
        }
    }
}