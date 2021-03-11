using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class VoltarFases : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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
        SceneManager.LoadScene(index);
    }
}
