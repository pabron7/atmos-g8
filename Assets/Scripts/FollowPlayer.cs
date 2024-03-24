using UnityEngine;

public class ParticleSystemFollower : MonoBehaviour
{
    public Transform playerTransform; // Assign the player's transform in the inspector
    private ParticleSystem attachedParticleSystem;

    void Start()
    {
        attachedParticleSystem = GetComponent<ParticleSystem>();

        if (playerTransform == null)
        {
            Debug.LogError("Player Transform is not assigned in ParticleSystemFollower.");
            return;
        }

        StartCoroutine(FollowPlayer());
    }

    System.Collections.IEnumerator FollowPlayer()
    {
        while (true) // Loop indefinitely
        {
            yield return new WaitForSeconds(10); // Wait for 10 seconds

            // Update the particle system's position to the player's position
            if (attachedParticleSystem != null && playerTransform != null)
            {
                attachedParticleSystem.transform.position = playerTransform.position;
            }
        }
    }
}
