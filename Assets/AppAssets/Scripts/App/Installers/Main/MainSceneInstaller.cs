using UnityEngine;
using Zenject;

namespace AppName.App.Installers.Main
{
    public class MainSceneInstaller : MonoInstaller
    {
        [SerializeField]
        private Camera _mainCamera;
        
        public override void InstallBindings()
        {
            Container.BindInstances(
                _mainCamera);
        }
    }
}