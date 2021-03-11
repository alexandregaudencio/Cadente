using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// using UnityEngine.UI;

public class RecomecarFase : MonoBehaviour
{


    public AudioSource somToque;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void Awake ()
    {
     
    }



    //FadeIn:
    public Animator animator;
    public int index;

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
      
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
}
