using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public UnityEngine.UI.Text scoreText;
    public GameObject gameOverUI;

    [ContextMenu("updateScore")]
    public void updateScore(int update=1) {
        score += update;
        scoreText.text = $"score: {score}";
        // Debug.Log($"scoreText.text {scoreText.text}");
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        gameOverUI.SetActive(true);
    }
}
