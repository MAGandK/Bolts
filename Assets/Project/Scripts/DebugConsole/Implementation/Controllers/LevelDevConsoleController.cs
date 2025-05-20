using Project.LevelLoad;
using UnityEngine;
using Zenject;

namespace DebugConsole.Controllers
{
    public class LevelDevConsoleController : IDevConsoleController, ITickable
    {
        private readonly ILevelLoader _levelLoader;

        public LevelDevConsoleController(ILevelLoader levelLoader)
        {
            _levelLoader = levelLoader;
        }

        public void Tick()
        {
            LoadLevels();
        }

        private void LoadLevels()
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                _levelLoader.LoadNextLevel();
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                _levelLoader.LoadCurrentLevel();
            }
        }

        public void Init()
        {
            
        }
    }
}