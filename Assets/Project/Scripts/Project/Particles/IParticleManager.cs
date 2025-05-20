using Project.Particles.ParticleSetting;
using UnityEngine;

namespace Project.Particles
{
    public interface IParticleManager
    {
        void Play(ParticleType particleType, Vector3 position);
        void ReturnAllParticle();
    }
}