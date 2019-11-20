using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{

    public float speed = 20f;
    public int health = 10;
    public int score = 0;
    public TextMeshProUGUI healthDisplay;
    public TextMeshProUGUI scoreDisplay;

    private Rigidbody2D rb;
    private Vector2 movePos;

    private float x;
    private float y;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        updateUI();

        Vector2 inputMove = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        movePos = inputMove.normalized * speed;

        x = Mathf.Clamp(rb.position.x, -33, 33);
        y = Mathf.Clamp(rb.position.y, -19, 19);

        rb.position = new Vector2(x, y);
       
    }

    void FixedUpdate()
    {
       rb.MovePosition(rb.position + movePos * Time.fixedDeltaTime);
    }

    private void updateUI()
    {
        healthDisplay.text = "HEALTH : " + health;
        scoreDisplay.text = "SCORE : " + score;
    }
}
