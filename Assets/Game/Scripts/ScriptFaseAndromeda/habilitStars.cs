using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class habilitStars : MonoBehaviour
{

    public GameObject cisne1;
    public GameObject cisne2;
    public GameObject cisne3;
    public GameObject cisne4;
    public GameObject cisne5;
    public GameObject cisne6;
    public GameObject cisne7;
    public GameObject cisne8;






    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("estrelaCisne1") > 0)
        {
        //    cisne1.GetComponent<Renderer>().color = new Color32(255, 0, 225, 255);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
