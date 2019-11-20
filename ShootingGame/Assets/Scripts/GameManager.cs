using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
 

    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        checkHealth();
    }

    private void checkHealth()
    {
        if(player.health <= 0)
        {
         
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Enemy.speed = 8f;

        }
    }
}
