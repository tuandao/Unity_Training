using UnityEngine;

public class BallController : MonoBehaviour
{
    public float moveX;
    public float moveY;
    public GameObject enemy;
    public Rigidbody2D rb;

    private SpriteRenderer playerRenderer;
    private SpriteRenderer enemyRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerRenderer = GetComponent<SpriteRenderer>();
        enemyRenderer = enemy.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = new Vector2(moveX, moveY);
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        transform.Translate(move * Time.deltaTime * 5f, Space.World);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision happen!");
        if (collision.gameObject == enemy)
        {
            playerRenderer = GetComponent<SpriteRenderer>();
            enemyRenderer = collision.gameObject.GetComponent<SpriteRenderer>();
            if (playerRenderer != null && enemyRenderer != null)
            {
                playerRenderer.color = enemyRenderer.color;

                enemyRenderer.color = new Color(Random.value, Random.value, Random.value, 1f);
                //rb.addForce(new Vector2(Random.Range(-100f, 100f), Random.Range(-100f, 100f)));
            }
        }

    }
}


