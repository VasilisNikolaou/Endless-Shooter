using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public GameObject shot;
    public AudioSource audioSource;
    public AudioClip playerAttack;

    private Transform playerPos;

    // Start is called before the first frame update
    void Start()
    {
        playerPos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetMouseButtonDown(0))
         {
            audioSource.PlayOneShot(playerAttack);
            Instantiate(shot, playerPos.position, Quaternion.identity);
         }
           
    }

}
