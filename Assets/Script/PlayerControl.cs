using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputAction MoveAction;
    Rigidbody2D rigidbody2d;
    Vector2 move;
    public float speed = 3.0f;
    Animator animator;
    Vector2 moveDirection = new Vector2(1, 0);

    public float moveX;
    public float moveY;

    void Start()
    {
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = new Vector2(moveX, moveY);
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");


        /*
        move = MoveAction.ReadValue<Vector2>();
        UnityEngine.Debug.Log($"MoveX: {move}");

        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            moveDirection.Set(move.x, move.y);
            moveDirection.Normalize();
        }
        */

        animator.SetFloat("Look X", moveX);
        animator.SetFloat("Look Y", moveY);
        //animator.SetFloat("Speed", move.magnitude);

        transform.Translate(move * Time.deltaTime * speed, Space.World);

    }

    private void FixedUpdate()
    {
     //   Vector2 position = (Vector2)rigidbody2d.position + move * speed * Time.deltaTime;
      //  rigidbody2d.MovePosition(position);
    }

}


