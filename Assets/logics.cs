using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logics : MonoBehaviour
{
    public int playerscore;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerscore += 1;
        scoreText.text = playerscore.ToString();
    }
    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void quitgame()
    {
        gameOverScreen.SetActive(true);
    }
}
