using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Director : MonoBehaviour
{

    private Timer timerCenario;
    private Sansao sansao;
    public GameObject avisoAchou;
    public GameObject avisoTempo;
    private AudioSource tocaSomDerrota;
    private Audio objetoAudio;
    private Pontuacao pontuacao;
    private int cenarioAtual;
    private bool verificaAchou;
    private bool acabouTempo;
    private string nomeCena;
    

    private void Awake() {
       //DontDestroyOnLoad(this);
        
        avisoAchou = GameObject.Find("Aviso_achou");
        avisoTempo = GameObject.Find("Aviso_tempo");
        if (avisoAchou != null && avisoTempo != null)
        {
            avisoAchou.SetActive(false);
            avisoTempo.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        verificaAchou = false;
        acabouTempo = false;
        this.timerCenario = GameObject.FindObjectOfType<Timer>();
        this.sansao = GameObject.FindObjectOfType<Sansao>();
        nomeCena = SceneManager.GetActiveScene().name;
        this.pontuacao = gameObject.GetComponent<Pontuacao>();
        pontuacao.DefineTempoInicial(timerCenario.timeInitial);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            timerCenario.StartTime();
        }

        if (verificaAchou)
        {
            avisoAchou.GetComponent<PlayAchou>().PlaySomAchou();
        }

        if (acabouTempo)
        {
            avisoTempo.GetComponent<PlayDerrota>().PlaySomTempo();
        }

        VerificaTempo();

        VerificaCliqueAchou();

        if(Input.GetKeyDown(KeyCode.Escape)){
            
            Application.Quit();

        }
    }

    public void BotaoProximaFase()
    {
        if (verificaAchou)
        {
            VerificaProximaFase();
        }
    }

    public void BotaoPerdeuJogo()
    {
        if (acabouTempo)
        {
            ReiniciaJogo();
        }
    }

    public void SiteHistoria()
    {
        Application.OpenURL("https://www.dentrodahistoria.com.br/");
    }

    public void JogarNovamente()
    {
       SceneManager.LoadScene("CenarioMenu");
    }

    void ReiniciaJogo()
    {
        verificaAchou = false;
        avisoTempo.SetActive(false);
        sansao.ResetClick();
        timerCenario.StopTime();
        timerCenario.RestartTime();
        acabouTempo = false;
        SceneManager.LoadScene("CenarioMenu");
    }

    void VerificaCliqueAchou()
    {
        if(sansao.cliquei==true && timerCenario.timeRemaining > 0)
        {
            avisoAchou.SetActive(true);
            timerCenario.StopTime();
            pontuacao.PontuacaoDaFase(timerCenario.timeRemaining);
            pontuacao.SetContagem(true);
            verificaAchou = true;
        }
    }

    void VerificaProximaFase()
    {
        if(verificaAchou && nomeCena == "Cenario1")
        {          
            SceneManager.LoadScene("Cenario2");
        }
        else if(verificaAchou && nomeCena == "Cenario2")
        {
            SceneManager.LoadScene("Cenario3");
        }
        else if(verificaAchou && nomeCena == "Cenario3")
        {
            SceneManager.LoadScene("Cenario4");
        }
        else if(verificaAchou && nomeCena == "Cenario4")
        {
            SceneManager.LoadScene("Cenario5");
        }
        else if(verificaAchou && nomeCena == "Cenario5")
        {
            SceneManager.LoadScene("Cenario6");
        }
        else if(verificaAchou && nomeCena == "Cenario6")
        {
            SceneManager.LoadScene("Cenario7");
        }
        else if(verificaAchou && nomeCena == "Cenario7")
        {
            SceneManager.LoadScene("CenarioFinal");
        }
        else if(verificaAchou && nomeCena == "CenarioFinal")
        {
            SceneManager.LoadScene("CenarioMenu");
        }
    }

    void VerificaTempo()
    {
        if(timerCenario.timeRemaining == 0)
        {
            avisoTempo.SetActive(true);
            acabouTempo = true;
            //if(objetoAudio != null)
            //{
                //Destroy(GetComponent<AudioSource>());
                //audioFundo.Stop();
                //tocaSomDerrota.Play();
                //tocaSomDerrota.Play();
                //DestroyImmediate(GetComponent<AudioSource>());
                //objetoAudio.SendMessage("Destruir");
                //pontuacao.ZeraPontos();
                //Debug.Log("Enviando Mensagem para Pontuação");
            //}
        }
    }

}
