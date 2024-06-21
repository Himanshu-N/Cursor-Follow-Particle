using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePopSound : MonoBehaviour
{
    ParticleSystem particleSystemRef;
    int previousNumberOfParticles;
    int currentNumberOfParticle;
    [SerializeField] AudioSource emitSound;

    // Start is called before the first frame update
    void Start()
    {
        particleSystemRef = gameObject.GetComponent<ParticleSystem>();
        previousNumberOfParticles = 0;
    }

    // Update is called once per frame
    void Update()
    {
        int currentNumberOfParticles = particleSystemRef.particleCount;
        if (currentNumberOfParticles > previousNumberOfParticles)
        {
            emitSound.Play();
        }
        previousNumberOfParticles = currentNumberOfParticles;
    }
}
