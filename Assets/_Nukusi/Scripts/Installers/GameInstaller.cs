using Assets._Nukusi.Scripts.Entities;
using Assets._Nukusi.Scripts.Entities.Living;
using Assets._Nukusi.Scripts.Entities.Inanimate;
using Assets._Nukusi.Scripts.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Assets._Nukusi.Scripts.Installers
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.BindFactory<ObstacleType, Vector3, IObstacle, ObstacleFactory>().FromFactory<ExtendedObstacleFactory>();
            Container.BindFactory<UnitType, Vector3, IUnit, UnitFactory>().FromFactory<ExtendedUnitFactory>();
            Container.BindInterfacesAndSelfTo<GameManager>().AsSingle();
        }
    }
}