using Assets._Nukusi.Scripts.Entities.Living;
using Assets._Nukusi.Scripts.Entities.Inanimate;
using Assets._Nukusi.Scripts.GameState;
using UnityEngine;
using Zenject;
using Assets._Nukusi.Scripts.VFX;
using Assets._Nukusi.Scripts.UI;
using Assets._Nukusi.Scripts.Common;

namespace Assets._Nukusi.Scripts.Installers
{
    public class GameInstaller : MonoInstaller
    {
        [SerializeField] private GameObject particlePrefab;
        [SerializeField] private UIManager uiManager;
        [SerializeField] private Borders borders;

        public override void InstallBindings()
        {
            Container.BindFactory<ObstacleType, Vector3, IObstacle, ObstacleFactory>().FromFactory<ExtendedObstacleFactory>();
            Container.BindFactory<UnitType, Vector3, IUnit, UnitFactory>().FromFactory<ExtendedUnitFactory>();
            Container.BindFactory<Vector3, RectTransform, Healthbar, HealthbarFactory>().FromFactory<ExtendedHealthbarFactory>();

            Container.BindInterfacesAndSelfTo<GameManager>().AsSingle();
            Container.BindInterfacesAndSelfTo<ObstacleSpawner>().AsSingle();
            Container.BindInterfacesAndSelfTo<UnitSpawner>().AsSingle();

            Container.BindInstance(uiManager);
            Container.BindInstance(borders);

            Container.BindMemoryPool<BasicParticle, BasicParticle.Pool>().WithInitialSize(20)
                .FromComponentInNewPrefab(particlePrefab).UnderTransformGroup("VFX");
        }
    }
}