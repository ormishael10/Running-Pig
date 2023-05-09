using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speedY;
    public float speedX;
    float xDir;
    public static float playerHealth;
    float maxHealth = 50;

    public AudioSource audio;
    public AudioClip hurt;
    public AudioClip eat;

    void Start()
    {
        playerHealth = maxHealth;
        rb = GetComponent<Rigidbody2D>();
        speedY = 2.6f;
        speedX = 7f;
        
    }

   
    void Update()
    {
        xDir = Input.GetAxis("Horizontal") * speedX * Time.deltaTime;
         //transform.position = new Vector2(transform.position.x * xDir , transform.position.y);
        transform.Translate(new Vector2(xDir, speedY * Time.deltaTime));

        if(playerHealth == 0)
        {
            SceneManager.LoadScene("TryAgain");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Pork")
        {
            speedY += 0.2f;
            ScoreManager.instance.AddPointToScore();
            Destroy(collision.gameObject);
            audio.PlayOneShot(eat);

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hole")
        {
            playerHealth -= 10f;
            audio.PlayOneShot(hurt); 
        }
    }
}
