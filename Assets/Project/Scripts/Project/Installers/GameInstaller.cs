using Zenject;

namespace Project.Installers
{
    public class GameInstaller : MonoInstaller
    {
        [Inject] private DiContainer _diContainer;

        public override void InstallBindings()
        {
           
        }
    }
}