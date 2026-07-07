using UnityEngine;

public class GoalZone : MonoBehaviour
{
    private ScoreManager scoreManager;

    void Start()
    {
        // Find our ScoreManager object in the scene automatically
        scoreManager = FindFirstObjectByType<ScoreManager>();
    }

    // This runs automatically whenever any object rolls into our trigger zone
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object passing through has "Ball" in its name
        if (other.gameObject.name.Contains("Ball"))
        {
            if (scoreManager != null)
            {
                scoreManager.AddPoint();
            }
            
            // OPTIONAL: Destroy the ball or reset its position here 
            // so the player can't score 100 times with the same kick!
            Destroy(other.gameObject); 
            Debug.Log("Ball destroyed after scoring.");
        }
    }
}