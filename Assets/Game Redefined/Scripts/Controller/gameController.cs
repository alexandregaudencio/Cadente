using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject comet;
  
    public GameObject canvasWin;
    

    public void ResetLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void LevelComplete() {
        canvasWin.SetActive(true);
    }
    
    

}
