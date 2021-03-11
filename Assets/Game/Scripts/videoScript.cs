using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// using UnityEngine.UI;

public class videoScript : MonoBehaviour
{
    public Animator animator;
    public int DuracaoDoVideo;
    public int index;




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TempoVideo());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();

        }
    }


    public void FadeToLevel(int levelIndex)
    {

        animator.SetTrigger("FadeOut");
        StartCoroutine(FadingOut());
    }


    IEnumerator TempoVideo()
    {
        yield return new WaitForSeconds(DuracaoDoVideo);
        animator.SetTrigger("FadeOut");
        yield return new WaitForSeconds(1);
        FadeComplete();
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
