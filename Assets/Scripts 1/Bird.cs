using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public float speed = 1;

    public GameObject gameOverPanel;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            _rigidbody.velocity = Vector2.up * speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
