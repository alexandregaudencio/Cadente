using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercollisions : MonoBehaviour
{
    // Start is called before the first frame update  private PlayerController playerController;
    private PlayerController playerController;
    private GameController gameController;
    public GameObject comet;
    public GameObject portalExit;


    void Start()
    {
        
    }
    void Update()
    {
        // if (playerController.gameStarted) {
            
        // }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("portalExit")) {
            this.gameObject.GetComponent<Renderer>().enabled = false;
            this.gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            
            gameController.LevelComplete(); 
        }

        if( other.gameObject.CompareTag("limit")) {
            gameController.ResetLevel();
        }
    }


    // void OnBecameInvisible()
    // {
    //     gameController.ResetLevel();
    // }



}
