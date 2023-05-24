using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HelixJump.Particle
{
    public class ParticleController : MonoBehaviour
    {
        [SerializeField] private ParticleSystem[] _particleFx;
        
        private const byte JUMPFX = 0;
        private const byte DEADFX = 1;
        
        public void JumpFxPlay()
        {
            _particleFx[JUMPFX].Play();
        }
        public void DeadFxPlay()
        {
            _particleFx[DEADFX].Play();
        }
    }
}