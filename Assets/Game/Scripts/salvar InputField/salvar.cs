using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salvar : MonoBehaviour
{
    // public Text txt;
    // public InputField caixaTxt;
    private float testeF;
    private int testeI;

    // Start is called before the first frame update
    void Start()
    {
        // txt.text = PlayerPrefs.GetInt("Pontosi").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SalvarFloat ()
    {
        // testeI = int.Parse(caixaTxt.text);
        PlayerPrefs.SetInt("Pontosi", testeI);
        
    }



}
