using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static float speed = 8f;
    public GameObject effect;

    private CameraShake cameraShake;
    private Transform playerPosition;
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

        cameraShake = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraShake>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPosition.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("Player"))
        {
            GameObject instantiateEffect = Instantiate(effect, transform.position, Quaternion.identity);
            cameraShake.TriggerShake();
            player.health--;
            Destroy(gameObject);
            Destroy(instantiateEffect, 1);

            speed += 0.5f;
        }

        if(collision.CompareTag("Bullet"))
        {
            GameObject instantiateEffect = Instantiate(effect, transform.position, Quaternion.identity);
            cameraShake.TriggerShake();
            player.score++;
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Destroy(instantiateEffect, 1);

            speed += 0.5f;
        }
    }
}
