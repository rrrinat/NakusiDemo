using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Nukusi.Scripts.Entities.Inanimate
{
    public interface IObstacle : IGameObjectComponent
    {
        Collider2D Collider { get; }
        Rigidbody2D Rigidbody { get; }
        Transform transform { get; }

        Vector3 position { get; set; }
    }
}