using System.Diagnostics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Moving : MonoBehaviour
{
    void Update()
    {
        
        Vector2 position = transform.position;
       // position.x = position.x + 0.1f;
        //transform.position = position;
        
        float horizontal = 0.0f;
        if (Keyboard.current.leftArrowKey.isPressed)
        {

            horizontal = -1.0f;
            position.x = position.x + horizontal;

        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {

            horizontal = 1.0f;
            position.x = position.x + horizontal;

        }
        transform.position = position;

        //Debug.Log(horizontal);
    }
}
