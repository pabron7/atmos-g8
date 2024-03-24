using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemController : MonoBehaviour
{
    public List<ParticleSystemEntry> particleSystemsEntries;

    void Update()
    {
        // Iterate through all entries and update their state based on the activate boolean
        foreach (var entry in particleSystemsEntries)
        {
            // Check if the particle system is not null
            if (entry.particleSystem != null)
            {
                // Activate or deactivate the particle system based on the entry's activate boolean
                if (entry.activate && !entry.particleSystem.isPlaying)
                {
                    entry.particleSystem.Play();
                }
                else if (!entry.activate && entry.particleSystem.isPlaying)
                {
                    entry.particleSystem.Stop();
                }
            }
        }
    }
}
