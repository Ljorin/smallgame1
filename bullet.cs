using UnityEngine;

public class Bullet : MonoBehaviour;
{
    public float lifetime = 2f;

    private void Start()
    {
        Destroy(GameObject, lifetime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(GameObject);
    }
}