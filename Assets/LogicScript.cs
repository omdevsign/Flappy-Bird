using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increament Score")]
    public void addScore(int ScoreToAdd)
    {
        playerScore= playerScore + ScoreToAdd;
        scoreText.text = playerScore.ToString();
    }
    public void restartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
