using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Nukusi.Scripts.Entities
{
    public interface IGameObjectComponent
    {
        GameObject gameObject { get; }
    }
}