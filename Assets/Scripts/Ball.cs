using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float power;
    [SerializeField]
    private Vector2 destino;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3 )
        {
            timer = 0;
            rb.velocity = Vector2.zero;
            rb.position = Vector2.zero;
            rb.AddForce(destino * power, ForceMode2D.Force);
        }
    }

}
