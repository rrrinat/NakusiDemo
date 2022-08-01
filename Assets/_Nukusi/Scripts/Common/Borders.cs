using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Nukusi.Scripts.Common
{
    public class Borders : MonoBehaviour
    {
        [SerializeField]
        private Vector3 size = default;

        private Vector3 halfSize;

        public Vector3 HalfSize => halfSize;

        public Vector2 Min
        {
            get;
            private set;
        }

        public Vector2 Max
        {
            get;
            private set;
        }

        private void Awake()
        {
            Initialize();
        }

        private void Initialize()
        {
            halfSize = size * 0.5f;

            var position = transform.position;

            Min = new Vector3(position.x - halfSize.x, position.y - halfSize.y);
            Max = new Vector3(position.x + halfSize.x, position.y + halfSize.y);
        }

        private void OnDrawGizmos()
        {
            var color = Color.white;
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(transform.position, size);

            Gizmos.color = color;
        }
    }
}