using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    bool isGameOver = false;
    // Score variable
    public int playerScore;

    // UI text to show score
    public Text scoreText;

    // Game over screen reference
    public GameObject gameOverScreen;
    

    // 🔹 This function is called when bird passes a pipe

    void Start()
    {
        Time.timeScale = 1f;
        SoundManager.instance.PlayBackground();
    }
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;          // increase score
        scoreText.text = playerScore.ToString();         // update UI text

        // 🔊 PLAY SCORE SOUND
        SoundManager.instance.PlayScore();
    }

    // 🔹 Restart button function
    public void restartGame()
    {
        isGameOver = false;
        Time.timeScale = 1f;

        FindFirstObjectByType<TimeRewind>().ResetRewind();

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // 🔹 Game over function (called from BirdScript)
    public void gameOver()
    {
        if (isGameOver) return;
        isGameOver = true;

        SoundManager.instance.StopBackground();
        SoundManager.instance.PlayGameOver();

        Time.timeScale = 0f;
        gameOverScreen.SetActive(true);
        
    }
}
