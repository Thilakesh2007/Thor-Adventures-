using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player; // Reference to the player
    [SerializeField] private float smoothSpeed = 0.1f; // Smooth movement

    void Update()
    {
        if (player != null) // Check if player is assigned
        {
            Vector3 targetPosition = new Vector3(player.position.x, player.position.y+1.50f, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed);
        }
    }
}
