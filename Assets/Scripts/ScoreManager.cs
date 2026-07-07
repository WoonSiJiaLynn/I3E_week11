using UnityEngine;
using TMPro; // Crucial! This lets the script talk to TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public static int currentScore = 0;
    
    // This creates a slot where we can drop our screen text object
    public TextMeshProUGUI scoreTextDisplay;

    void Start()
    {
        // Make sure the screen displays "Score: 0" when the game kicks off
        UpdateScoreUI();
    }

    public void AddPoint()
    {
        currentScore++;
        Debug.Log("⚽ GOAL!!! Total Score: " + currentScore);
        
        // Update the numbers on the player's screen!
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (scoreTextDisplay != null)
        {
            scoreTextDisplay.text = "Score: " + currentScore;
        }
    }
}