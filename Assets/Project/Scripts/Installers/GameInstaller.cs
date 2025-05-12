using Zenject;

namespace Installers
{
    public class GameInstaller : MonoInstaller
    {
        [Inject] private DiContainer _diContainer;

        public override void InstallBindings()
        {
           
        }
    }
}