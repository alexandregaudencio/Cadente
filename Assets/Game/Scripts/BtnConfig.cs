using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnConfig : MonoBehaviour
{

    private bool liga = false;
    public Animator animConfig;
    public Animator animaEngre;


    public void ClickBtn()
    {
        liga = !liga;

        if (liga)
        {
            animConfig.Play("ConfigAnim");
            animaEngre.Play("AnimaEngrenagem");
        }
        else
        {
            animConfig.Play("ConfAnimInvers");
            animaEngre.Play("AnimaEngrenagemInvers");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
