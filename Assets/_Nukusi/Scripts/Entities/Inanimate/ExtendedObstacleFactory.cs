using Assets._Nukusi.Scripts.Entities.Inanimate;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ExtendedObstacleFactory : IFactory<ObstacleType, Vector3, IObstacle>
{
    private readonly DiContainer container;

    public ExtendedObstacleFactory(DiContainer container)
    {
        this.container = container;
    }

    public IObstacle Create(ObstacleType obstacleType, Vector3 position)
    {
        var prefab = Resources.Load<GameObject>($"Prefabs/Obstacles/{obstacleType}");
        var obstacle = container.InstantiatePrefabForComponent<IObstacle>(prefab);
        obstacle.position = position;

        return obstacle;
    }
}
