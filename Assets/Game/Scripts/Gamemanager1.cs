using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Gamemanager1 : MonoBehaviour
{
    public static Gamemanager1 instance;

    private int toqueLua = 0;
    //cometa
    [SerializeField]
    private GameObject cometa1;

    public int varCountCometa = 1;
    public int varEstrela = 0;
    public bool trava = false;

    public GameObject ponteiro;
    public GameObject ParticleSystem;

    [SerializeField]
    private Renderer cometaRenderer;
    [SerializeField]
    private float vidaCometa = 1.0f;
    [SerializeField]
    private Color cor;
    [SerializeField]
    private bool tocaObj = false;

    private bool tocouPortal = false;

   

    public GameObject UIfim;
    private Renderer UIRenderer;
    // private float vidaFim = 1.0f;
    private Color corfim;

    public Transform posPortal;
    

    public GameObject btnProxFase;


    //som estrela:
    public AudioSource somStars;
    public AudioSource somStars2;
    public AudioSource somStars3;
    public AudioSource somEntrandoPortal;
    public AudioSource somColMoon;



    public GameObject UIestrela1;
    public GameObject UIestrela2;
    public GameObject UIestrela3;

  



    public Animator animFade;
    public Animator animWhite;



    public void Awake ()
    {
        tocaObj = false; 
    }

    void Start()
    {
        cor = cometaRenderer.material.GetColor("_Color");
        corfim = UIRenderer.material.GetColor("_Color");
        varEstrela = 0;
    }

    void Update()
    {
        if (tocaObj == true && varCountCometa == 1)
        {
            StartCoroutine(tempoColisao());
        }

        StartCoroutine(estrelasUIanim());

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("SelecaoFases");
        }

        if (varEstrela > PlayerPrefs.GetInt("estrelaCisne1"))
        {
            SalvarPlayerPrefs();

        }


    }






    //Salvar playerprefs:
    public void SalvarPlayerPrefs ()
    {
        PlayerPrefs.SetInt ("estrelaCisne1", varEstrela);
    }





    
    //colisão com estrela:
    void OnTriggerEnter2D (Collider2D outro)
    {
        if (outro.gameObject.CompareTag("estrela") && varEstrela == 0)
        {
            ///  somStars.Play();
            Destroy(outro.gameObject);

            somStars.Play();
            varEstrela += 1;
            PlayerPrefs.SetInt("estrelas", varEstrela);
        }
        else if (outro.gameObject.CompareTag("estrela") && varEstrela == 1)
        {
            ///  somStars.Play();
            Destroy(outro.gameObject);
            somStars2.Play();
            varEstrela += 1;
        }
        else if (outro.gameObject.CompareTag("estrela") && varEstrela == 2)
        {
            ///  somStars.Play();
            Destroy(outro.gameObject);

            somStars3.Play();
            varEstrela += 1;
        }

      



    }


    //Colisão com lua e com os limites da tela, portal e lua:
    public void OnCollisionEnter2D(Collision2D outro2)
    {
        if (outro2.gameObject.CompareTag("lua"))
        {
            tocaObj = true;
            toqueLua++;
            transform.DetachChildren();
            ParticleSystem.SetActive(false);
            if (tocouPortal == false)
            {
                somColMoon.Play();
            }
            if(toqueLua == 1)
            {
               somColMoon.Play();
            }

           
        }

        else if (outro2.gameObject.CompareTag("limite"))
        {
            tocaObj = true;
            transform.DetachChildren();
            ParticleSystem.SetActive(false);
        }

        else if (outro2.gameObject.CompareTag("portal"))
        {
         //   animWhite.SetTrigger("fadeWhite");
            UIfim.SetActive(true);
            tocouPortal = true;
            vitoria();
            somEntrandoPortal.Play();
            if (varEstrela == 0)
            {
                btnProxFase.SetActive(false);
            }
        }

    }


    void vitoria ()
    {

        varCountCometa--;
        tocaObj = true;
        transform.DetachChildren();
        ParticleSystem.SetActive(false);
        cometa1.GetComponent<Renderer>().enabled = false;
         
        


    }

    IEnumerator tempoColisao ()
    {
        yield return new WaitForSeconds(1);
        MataCometa();
    }

    void MataCometa()
    {
        if (vidaCometa > 0)
        {
            vidaCometa -= Time.deltaTime;
            cometaRenderer.material.SetColor("_Color", new Color(cor.r, cor.g, cor.b, vidaCometa));
        }
        if (vidaCometa <= 0)
        {
            animFade.SetTrigger("FadeOut");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            


        }
    }

    IEnumerator estrelasUIanim()
    {
        if (tocaObj == true && varCountCometa == 0 && varEstrela == 1)
        {
            yield return new WaitForSeconds(1);
            UIestrela1.SetActive(true);
        }
        else if (tocaObj == true && varCountCometa == 0 && varEstrela == 2)
        {
            yield return new WaitForSeconds(1);
            UIestrela1.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            UIestrela2.SetActive(true);
        }
        else if (tocaObj == true && varCountCometa == 0 && varEstrela == 3)
        {
            yield return new WaitForSeconds(1);
            UIestrela1.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            UIestrela2.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            UIestrela3.SetActive(true);
        }
    }








}
