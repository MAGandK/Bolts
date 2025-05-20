using Project.Audio.Types;
using UnityEngine;

namespace Project.Audio.Settings
{
    [CreateAssetMenu(menuName = "Sound/Preset/Create MusicPreset", fileName = "MusicPreset", order = 0)]
    public class MusicPreset : AudioPreset
    {
        [SerializeField] private MusicType _musicType;

        public MusicType MusicType => _musicType;
    }
}