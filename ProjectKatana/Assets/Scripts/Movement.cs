using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    float horizontal;
    GameObject player;

    [SerializeField]
    private Rigidbody2D rg;
    [SerializeField]
    private Transform groundCheck;
    [SerializeField]
    private LayerMask groundLayer;

    private void Start()
    {
        player = gameObject;
        rg = GetComponent<Rigidbody2D>();
    }
    public void MoveStep(float velocity, float jumpVelocity)
    {
        if(Input.GetButtonDown("Jump") && isGrounded())
        {
            rg.velocity = new Vector2(rg.velocity.x, jumpVelocity);
        }

        horizontal = Input.GetAxisRaw("Horizontal");
        rg.velocity = new Vector2(velocity * horizontal, rg.velocity.y);

        Flip();
    }
    public bool isMoving()
    {
        return horizontal != 0;
    }
    private void Flip()
    {
        if (horizontal == 0) return;
        int isRight = horizontal > 0 ? 1 : -1;
        player.transform.localScale = new Vector3(Mathf.Abs(player.transform.localScale.x) * isRight, player.transform.localScale.y, player.transform.localScale.z);
    }
    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
