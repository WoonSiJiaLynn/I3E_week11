using UnityEngine;
using UnityEngine.InputSystem; // Added to support the new controller input

public class NewGiftBox : MonoBehaviour
{
    public GameObject ballPrefab;
    public float interactionDistance = 3.0f;
    
    private Transform playerTransform;
    private int pressCount = 0;

    void Start()
    {
        // Automatically find the Starter Assets player via Tag
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null) playerTransform = player.transform;
    }

    void Update()
    {
        if (playerTransform == null) return;

        float distance = Vector3.Distance(transform.position, playerTransform.position);
        
        if (distance <= interactionDistance)
        {
            // The New Input System way to check if a specific keyboard key was hit this frame
            if (Keyboard.current.eKey.wasPressedThisFrame)
            {
                pressCount++;
                Debug.Log("GiftBox hit " + pressCount + "/3 times!");

                if (pressCount >= 3)
                {
                    // Spawn the ball slightly in front of the box location
                    Instantiate(ballPrefab, transform.position + Vector3.up, transform.rotation);
                    Destroy(gameObject);
                }
            }
        }
    }
}