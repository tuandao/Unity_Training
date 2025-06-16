using UnityEngine;

public class EnemyScript: MonoBehaviour
{
    void Update()
    {
        Vector2 position = transform.position;
        position.x = position.x + 0.1f;
        transform.position = position;
    }
}

