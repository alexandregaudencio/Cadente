using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 TouchPosition;
    public Camera cam;
    public Touch toque;

    public float impulse = 20000.0f;
    public GameObject comet;
    public GameObject Arrow;
    public GameObject portalEnter;
    public bool gameStarted = false;

    private PlayerInput playerInput;

    void Start()
    {
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        comet.transform.position = portalEnter.transform.position;
        // comet.gameObject.GetComponent<TrailRenderer>().enabled = true;
        comet.GetComponent<TrailRenderer>().enabled = true;
    }

    void FixedUpdate()
    {


    }



    void Update()
    {
        if (!gameStarted) {
            if (isInputButtonDown())
            {  
                Arrow.SetActive(true);
    
                TouchPosition = cam.ScreenToWorldPoint(InputPosition());
                TouchPosition.z = comet.transform.position.z;
                comet.transform.right = TouchPosition - comet.transform.position;
            
            }
            if (isInputButtonUp())
            {
                // ParticleSystem.SetActive(true);
                gameStarted = true;
                firstGameAction();
                
            }
        } 
            
    }

    private Vector3 InputPosition() {
        if (Input.touchCount == 1) {
            return Input.GetTouch(0).position;
        } 
          else {
            return Input.mousePosition;
         }
    }

    //como colocar estes objetos em outro script (playerInput.cs)?
    public bool isInputButtonDown() {
        bool isTouchDown = Input.touchCount > 0;
        bool isMouseDown = Input.GetMouseButton(0);
        if (isMouseDown) {
            return isMouseDown;
        } else {
            return isTouchDown;
        }
    }

    public bool isInputButtonUp() {
        bool isInputUp;
        if (Input.GetMouseButtonUp(0)) {
            isInputUp = true;
        } else if(Input.touchCount > 0) {
           isInputUp = Input.GetTouch(0).phase == TouchPhase.Ended ? isInputUp = true : isInputUp = false;
        } else {
            isInputUp = false;
        }
        return isInputUp;
        // rketurn false;


    }

    
    private void firstGameAction() {
        // comet.AddForce(new Vector2(
        // (TouchPosition.x - transform.position.x)/ (Mathf.Sqrt(Mathf.Pow(TouchPosition.x - transform.position.x, 2) + Mathf.Pow(TouchPosition.y - transform.position.y, 2))),
        // (TouchPosition.y - transform.position.y)/ (Mathf.Sqrt(Mathf.Pow(TouchPosition.x - transform.position.x, 2) + Mathf.Pow(TouchPosition.y - transform.position.y, 2)))) 
        // * impulse) ;
        Arrow.SetActive(false);
        comet.GetComponent<Rigidbody2D>().AddForce(new Vector2 (TouchPosition.x - comet.transform.position.x , TouchPosition.y - comet.transform.position.y).normalized*impulse);
        comet.GetComponent<Renderer>().enabled = true;
        

    }



}

