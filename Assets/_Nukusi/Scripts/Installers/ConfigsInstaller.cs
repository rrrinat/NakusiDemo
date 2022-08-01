using Assets._Nukusi.Scripts.Common;
using Assets._Nukusi.Scripts.Physics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Assets._Nukusi.Scripts.Installers
{
    [CreateAssetMenu(menuName = "Nakusi/Installers/Configs Installer")]
    public class ConfigsInstaller : ScriptableObjectInstaller<ConfigsInstaller>
    {
        [SerializeField] private PhysicsConfig physicsConfig;
        [SerializeField] private UnitSpawnerConfig unitSpawnerConfig;
        [SerializeField] private ObstacleSpawnerConfig obstacleSpawnerConfig;

        public override void InstallBindings()
        {
            Container.BindInstance(physicsConfig);
            Container.BindInstance(unitSpawnerConfig);
            Container.BindInstance(obstacleSpawnerConfig);
        }
    }
}