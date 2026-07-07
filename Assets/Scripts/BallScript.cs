using UnityEngine;
using UnityEngine.InputSystem; // Added to support the new controller input

public class NewBall : MonoBehaviour
{
    private Rigidbody rb;
    private Transform playerTransform;
    
    public float kickForce = 12f;
    public float interactionDistance = 3.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null) playerTransform = player.transform;
    }

    void Update()
    {
        if (playerTransform == null) return;

        float distance = Vector3.Distance(transform.position, playerTransform.position);
        
        if (distance <= interactionDistance)
        {
            if (Keyboard.current.eKey.wasPressedThisFrame)
            {
                // Kick the ball in the direction the PLAYER is looking
                Vector3 kickDirection = playerTransform.forward;
                kickDirection.y = 0.2f; // Give it a slight upward trajectory pop!

                rb.AddForce(kickDirection * kickForce, ForceMode.Impulse);
            }
        }
    }
}