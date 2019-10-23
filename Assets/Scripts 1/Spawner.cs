using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float _timer;

    public GameObject pipesPrefab;
    public float height;
    public float maxTime = 1f;

    private void Start()
    {
        Spawn();
    }

    private void Update()
    {
        if (_timer > maxTime) {
            Spawn();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void Spawn()
    {
        var newPipes = Instantiate(pipesPrefab);
        var y = Random.Range(-height, height);

        newPipes.transform.position = new Vector2(transform.position.x, y);
        Destroy(newPipes, 20f);
    }
}
