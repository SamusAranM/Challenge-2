using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb2d;
    private int score;
    private int lives;
    private int count;

    public float speed;
    public float jumpForce;

    public Text scoreText;
    public Text winText;
    public Text livesText;
    public Text countText;

    public AudioClip winMusic;
    public AudioSource MusicSource;

    // Start is called before the first frame update
    // Player controller for Challenge 2
    void Start() {

        rb2d = GetComponent<Rigidbody2D>();

        score = 0;

        winText.text = "";

        lives = 3;

        count = 0;

        SetAllText();

        MusicSource.clip = winMusic;
       

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKey("escape")) {

            Application.Quit();

        }

    }

    private void FixedUpdate() {

        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(moveHorizontal, 0);

        rb2d.AddForce(movement * speed);

    }

    private void OnCollisionStay2D(Collision2D collision) {

        if(collision.collider.tag == "Ground") {

            if(Input.GetKey(KeyCode.UpArrow)) {

                rb2d.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);

            }

        }
        
    }

    private void OnTriggerEnter2D (Collider2D other) {

        if (other.gameObject.CompareTag("Pickup")) {

            other.gameObject.SetActive(false);

            score = score + 1;
            count = count + 1;

            if (score == 8) {

                MusicSource.Play();

            }

            SetAllText();

        }

        else if (other.gameObject.CompareTag("Enemy")) {

            other.gameObject.SetActive(false);

            score = score - 1;
            lives = lives - 1;
            SetAllText();

            if (lives == 0) {

                Destroy(this.gameObject);

            }

        }

        if (score == 4 && lives != 0 && count == 4) {

            transform.position = new Vector2(60.03f, transform.position.y);
            lives = 3;

        }

    }

    void SetAllText() {

        scoreText.text = "Score: " + score.ToString();

        livesText.text = "Lives: " + lives.ToString();

        countText.text = "Count: " + count.ToString();

        if (score >= 8) {

            winText.text = "You Win!";
        }

        else if (score < 4 && count == 4) {

            winText.text = "You Lose!";

        }

        else if (score < 8 && count == 8) {

            winText.text = "You Lose!";

        }

        else if (lives == 0) {

            winText.text = "You Lose!";

        }

    }
}
