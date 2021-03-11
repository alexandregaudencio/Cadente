using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class andSelectFase : MonoBehaviour
{
    public Animator animator;
    public int index;
    public AudioSource SomSelectFase;







    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            SceneManager.LoadScene("subSelecaoFases");

        }
    }

    public void FadeToLevel(int levelIndex)
    {
        SomSelectFase.Play();
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
