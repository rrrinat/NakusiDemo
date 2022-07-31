using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Nukusi.Scripts.Physics
{
    [CreateAssetMenu(menuName = "Nakusi/Common/Physics Config")]
    public class PhysicsConfig : ScriptableObject
    {
        [SerializeField] private ContactFilter2D obstacleFilter;
        [SerializeField] private ContactFilter2D unitFilter;

        public ContactFilter2D ObstacleFilter => obstacleFilter;
        public ContactFilter2D UnitFilter => unitFilter;

    }
}