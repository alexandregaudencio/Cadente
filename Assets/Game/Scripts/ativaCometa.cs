using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ativaCometa : MonoBehaviour
{

    public GameObject cometa1;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TempoStart());
    }

    // Update is called once per frame
    void Update()
    {

     

    }



    IEnumerator TempoStart()
    {
        yield return new WaitForSeconds(2);
        cometa1.SetActive(true);
    }
}
