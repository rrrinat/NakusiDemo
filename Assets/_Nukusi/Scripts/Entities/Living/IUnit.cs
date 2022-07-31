using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Nukusi.Scripts.Entities.Living
{
    public interface IUnit : IHasHealth, IGameObjectComponent
    {
        Collider2D Collider { get; }
        Transform transform { get; }

        Vector3 position { get; set; }
    }
}