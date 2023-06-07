using Microsoft.Cci;
using Mono.Cecil.Cil;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private  bool isGrounded = false;

    [SerializeField]
    private float force = 1;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) )
        { 
            rb.AddForce(Vector3.up * force , ForceMode2D.Impulse);
            //rb.AddForceAtPosition(Vector2.up, new Vector2(transform.position.x, transform.position.y - 0.25f) * force, ForceMode2D.Impulse);
        }

        if (Input.GetMouseButtonDown(1) )
        {
            transform.localScale *= 2;
        } 
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //isGrounded = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
        if (collision.gameObject.CompareTag("Pipe"))
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(0);
        }
    }


}
