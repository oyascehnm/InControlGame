using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator animator; // ⭐ Animator bileşeni

    Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>(); // ⭐ Animator'ı çekiyoruz
    }

    void Update()
    {
        // Tuşlardan yön bilgisini al
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // ⭐ Animator parametresini güncelle (hareket var mı yok mu)
        if (movement != Vector2.zero)
        {
            animator.SetBool("isWalking", true); // Yürüyorsa true
        }
        else
        {
            animator.SetBool("isWalking", false); // Duruyorsa false
        }

        // Karakterin yönüne göre Sprite'ı yatay eksende çevirmek
        if (movement.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if (movement.x < 0)
        {
            spriteRenderer.flipX = true;
        }
    }

    void FixedUpdate()
    {
        // Karakteri hareket ettir
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
