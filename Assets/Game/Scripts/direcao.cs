using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class direcao : MonoBehaviour
{


    private Vector3 position;
    public Camera cam;
    public Touch toque;

   
    public float impulse = 20000.0f;

    public Rigidbody2D cometa;
    public GameObject ponteiro;
    public GameObject cometaObj;
    public GameObject ParticleSystem;

    private Transform pos;

    public AudioSource somSaindoPortal;
    public bool primToque = true;


    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (toque.phase == TouchPhase.Began && primToque ==true)
            {
                cam = GameObject.Find("Main Camera").GetComponent<Camera>();
                ponteiro.SetActive(true);



                Touch toque = Input.GetTouch(0);
                position = cam.ScreenToWorldPoint(toque.position);
                position.z = transform.position.z;
                transform.right = position - transform.position;

                if (toque.phase == TouchPhase.Ended)
                {
                    ponteiro.SetActive(false);
                    ParticleSystem.SetActive(true);
                    somSaindoPortal.Play();
                    primToque = false;

                    cometa.AddForce(new Vector2(
                        (position.x - transform.position.x)/ (Mathf.Sqrt(Mathf.Pow(position.x - transform.position.x, 2) + Mathf.Pow(position.y - transform.position.y, 2))),
                        (position.y - transform.position.y)/ (Mathf.Sqrt(Mathf.Pow(position.x - transform.position.x, 2) + Mathf.Pow(position.y - transform.position.y, 2)))) 
                        * impulse) ;

                }
            }
        }
    }





}