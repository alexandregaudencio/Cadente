using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// using UnityEngine.UI;

public class WinManager : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }


    //FadeIn:
    public Animator animator;
    public int index;
    public AudioSource somToque;

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
