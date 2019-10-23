using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 1;

    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
