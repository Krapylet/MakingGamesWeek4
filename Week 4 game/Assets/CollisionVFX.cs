using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionVFX : MonoBehaviour
{
    ParticleSystem particles;

    private void Awake()
    {
        particles = gameObject.GetComponent<ParticleSystem>();
        particles.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        particles.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        particles.Stop();
    }

}
