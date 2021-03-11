using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FaseTroca1: MonoBehaviour
{

    public Animator animator;
    // private int LevelToLoad = 1;
    public AudioSource somToque;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            SceneManager.LoadScene("iniciar");
            
        }
    }



    public void FadeToLevel(int levelIndex)
    {
        somToque.Play();
        animator.SetTrigger("FadeOut");
        StartCoroutine(FadingOut());
    }


    
    IEnumerator FadingOut()
    {
        yield return new WaitForSeconds(1);
        FadeComplete();
    }
    public void FadeComplete()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
