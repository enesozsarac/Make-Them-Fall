using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private Game_Manager game_Manager;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float moveSpeed;

    [SerializeField] private float[] posX;

    [SerializeField] private bool isHit;
    [SerializeField] private bool isRight;
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,transform.position.y,transform.position.z));

        if (Input.GetMouseButtonDown(0)&& isHit == true && mousePos.x >= posX[0] && mousePos.x <= posX[1])
        {
            rb.velocity = new Vector2(moveSpeed,rb.velocity.y);

            Flip();
            
            isHit = false;
            if (isHit == false)
            {
                moveSpeed *= -1;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            isHit = true;
            
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Score"))
        {
            game_Manager.score++;
        }

        if (other.gameObject.CompareTag("enemy"))
        {
            game_Manager.GameOver();
        }

    }

    private void Flip()
    {
        isRight = !isRight;
        transform.Rotate(0f,180f,0);
    }



}
