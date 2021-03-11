using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelManager_playerPrefs : MonoBehaviour
{
    [System.Serializable]
    public class Level
    {
        public string levelText;
        public GameObject stars;
        public bool habilitado;
        public int desbloqueado;
        public int varEstrela;
    }


    //Estrelas:
    public GameObject star1_1;
    public GameObject star1_2;
    public GameObject star1_3;
    public GameObject star1_4;
    public GameObject star1_5;
    public GameObject star1_6;
    public GameObject star1_7;
    public GameObject star1_8;


    public GameObject botao;
    public Transform localBtn;
    public List<Level> levelList;
   
    


    // void DesbloqEstrela ()
    // {
    //     foreach (Level level in levelList)
    //     {
    //         if (level.habilitado == true)
    //         {
                

    //         }
    //     }
    // }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        



    }
}
