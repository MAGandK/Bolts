using Project.Audio.Settings;
using UnityEngine.Audio;

namespace Project.Audio
{
    public interface IAudioSettings
    {
        AudioPreset[] AudioPresets { get; }
        PooledAudio PooledAudioPrefab { get; }
        AudioMixer AudioMixer { get; }
    }
}