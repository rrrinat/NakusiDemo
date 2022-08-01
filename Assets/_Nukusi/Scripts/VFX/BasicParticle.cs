using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Assets._Nukusi.Scripts.VFX
{
    public class BasicParticle : MonoBehaviour
    {
        [Inject] private Pool pool;

        private float duration = 1f;

        private void Start()
        {
            StartCoroutine(WaitAndDespawn(duration));
        }

        private IEnumerator WaitAndDespawn(float duration)
        {
            yield return new WaitForSeconds(duration);

            pool.Despawn(this);
        }

        public class Pool : MonoMemoryPool<BasicParticle>
        {

        }
    }
}