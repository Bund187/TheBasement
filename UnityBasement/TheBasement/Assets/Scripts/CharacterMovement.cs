using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour
{

    public float moveSpeed;

    void Start()
    {

    }

    
    void FixedUpdate()
    {
        Move();
        
    }

    void Move()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        if (xMove > 0f)
        {
            transform.Translate(new Vector3(xMove * moveSpeed * Time.deltaTime, 0f, 0f));
        }
        if (xMove < 0f)
        {
            transform.Translate(new Vector3(xMove * moveSpeed * Time.deltaTime, 0f, 0f));

        }
    }
}
