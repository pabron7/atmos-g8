using UnityEngine;
using System.Collections;

public class FollowPlayerPeriodically : MonoBehaviour
{
    public Transform playerTransform; // Assign the player's Transform here via the Unity Editor
    public float updateInterval = 6f; // Time in seconds between position updates

    private IEnumerator Start()
    {
        // Continuously update the position at fixed intervals
        while (true)
        {
            if (playerTransform != null)
            {
                transform.position = playerTransform.position;
            }
            yield return new WaitForSeconds(updateInterval); // Wait for given seconds
        }
    }
}
