using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicaDeFundo : MonoBehaviour
{

    public AudioSource musicaFundo;
    static bool created = false;

    // Start is called before the first frame update
    void Start()
    {
        musicaFundo.Play();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        else
        {
            Destroy(this.gameObject);
        }












    }
}
