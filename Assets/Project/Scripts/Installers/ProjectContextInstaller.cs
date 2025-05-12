using Audio;
using Audio.Stoarge;
using Constants;
using DebugConsole;
using DebugConsole.Controllers;
using Particles;
using Particles.ParticleSetting;
using Pool;
using Services.Storage;
using UnityEngine;
using Zenject;
using AudioSettings = Audio.Settings.AudioSettings;

namespace Installers
{
    public class ProjectContextInstaller : MonoInstaller
    {
        [SerializeField] private AudioSettings _audioSettings; 
        [SerializeField] private ParticleSettings _particleSettings;

        public override void InstallBindings()
        {
            BindStorage();
            BindLevelloader();
            BindPools();
            BindSound();
            BindParticle();
            BindDebug();
        }

        private void BindDebug()
        {
            Container.Bind(typeof(IDevConsoleController), typeof(ITickable)).To<LevelDevConsoleController>().AsSingle()
                .NonLazy();
            Container.Bind<IDevConsoleController>().To<WalletDevConsoleController>().AsSingle().NonLazy();
            Container.Bind(typeof(IDevConsole), typeof(IInitializable)).To<DevConsole>().AsSingle().NonLazy();
        }
        
        private void BindParticle()
        {
            Container.Bind<IParticleSettings>().FromInstance(_particleSettings);
            Container.Bind(typeof(IParticleManager), typeof(IInitializable)).To<ParticleManager>().AsSingle().WithArguments(this);
        }
        
        private void BindSound()
        {
            Container.Bind<IAudioSettings>().FromInstance(_audioSettings);
            Container.Bind(typeof(IAudioManager), typeof(IInitializable)).To<AudioManager>().AsSingle().WithArguments(this);
        }
        
        private void BindLevelloader()
        {
            
        }

        private void BindStorage()
        {
            Container.Bind<IStorageData>().To<LevelProgressStorageData>().AsSingle()
                .WithArguments(StorageDataNames.LEVEL_PROGRESS_STORAGE_DATA_KEY);
           
            Container.Bind<IStorageData>().To<WalletStorageData>().AsSingle()
                .WithArguments(StorageDataNames.WALLET_STORAGE_DATA_KEY);
            
            Container.Bind<IStorageData>().To<AudioStorageData>().AsSingle()
                .WithArguments(StorageDataNames.AUDIO_DATA_KEY);

            Container.Bind(typeof(IStorageService), typeof(IInitializable)).To<StorageService>()
                .AsSingle()
                .NonLazy();
        }

        private void BindPools()
        {
            Container.Bind<IPool>().To<Pool.Pool>().AsSingle().NonLazy();
        }
    }
}