using Project.Audio.Types;
using UnityEngine;

namespace Project.Audio.Settings
{
    [CreateAssetMenu(menuName = "Sound/Preset/Create SoundPreset", fileName = "SoundPreset", order = 0)]
    public class SoundPreset : AudioPreset
    {
        [SerializeField] private SoundType _soundType;

        public SoundType SoundType => _soundType;
    }
}