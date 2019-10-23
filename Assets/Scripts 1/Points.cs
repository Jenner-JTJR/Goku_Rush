using UnityEngine;

public class Points : MonoBehaviour
{
    public GameManager gameManager;
    public Pipes pipes;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.score++;
        gameManager.scoreText.text = gameManager.score.ToString();
        pipes.speed ++;
    }
}
