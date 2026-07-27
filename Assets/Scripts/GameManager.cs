using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int currentScore = 0;

    [SerializeField]
    private TextMeshProUGUI scoreText;
    void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    
    public void AddScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;
        scoreText.text = "Score: " + currentScore;
    }

}

