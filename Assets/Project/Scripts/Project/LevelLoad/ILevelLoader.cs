using System;

namespace Project.LevelLoad
{
    public interface ILevelLoader
    {
        void LoadCurrentLevel(Action onFinished = null);
        void LoadNextLevel(Action onFinished = null);
    }
}