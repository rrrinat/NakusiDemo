using Assets._Nukusi.Scripts.Entities;
using Assets._Nukusi.Scripts.Entities.Living;
using Assets._Nukusi.Scripts.Entities.Inanimate;
using Assets._Nukusi.Scripts.GameState;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using Assets._Nukusi.Scripts.VFX;
using Assets._Nukusi.Scripts.UI;

namespace Assets._Nukusi.Scripts.Installers
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private GameObject particlePrefab;
        [SerializeField] private UIManager uiManager;
        [SerializeField] private GameObject healthbarPrefab;

        public override void InstallBindings()
        {
            Container.BindFactory<ObstacleType, Vector3, IObstacle, ObstacleFactory>().FromFactory<ExtendedObstacleFactory>();
            Container.BindFactory<UnitType, Vector3, IUnit, UnitFactory>().FromFactory<ExtendedUnitFactory>();
            Container.BindFactory<Healthbar, Healthbar.Factory>().FromComponentInNewPrefab(healthbarPrefab); ;
            Container.BindInterfacesAndSelfTo<GameManager>().AsSingle();
            Container.BindInstance(uiManager);

            Container.BindMemoryPool<BasicParticle, BasicParticle.Pool>().WithInitialSize(20)
                .FromComponentInNewPrefab(particlePrefab).UnderTransformGroup("VFX");
        }
    }
}