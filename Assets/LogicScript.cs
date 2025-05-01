using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public UnityEngine.UI.Text scoreText;

    [ContextMenu("updateScore")]
    public void updateScore(int update=1) {
        score += update;
        scoreText.text = $"Score: {score}";
        // Debug.Log($"scoreText.text {scoreText.text}");
    }
}
