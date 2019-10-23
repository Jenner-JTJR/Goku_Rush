using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public Pipes pipe;
    

    private void Start()
    {
        Time.timeScale = 1;    
    }

    public void RestartGame()
    {
        var activeScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(1);
        pipe.speed = 1f;
    }
}
