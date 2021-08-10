using UnityEngine;
using Zenject;

namespace AppName.App.Installers.Main
{
    public class MainInstaller : MonoInstaller
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