using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Director : MonoBehaviour
{
    
    private Timer timerCenario;
    private Sansao sansao;
    private int cenarioAtual;
    private bool verificaAchou;
    private bool acabouTempo;
    private string nomeCena;
    public GameObject textoAchei;
    public GameObject textoTempo;


    private void Awake() {
       //DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        verificaAchou = false;
        acabouTempo = false;
        this.timerCenario = GameObject.FindObjectOfType<Timer>();
        this.sansao = GameObject.FindObjectOfType<Sansao>();
        nomeCena = SceneManager.GetActiveScene().name;

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            timerCenario.StartTime();
            //Debug.Log("esconde");
        }

        if(verificaAchou && Input.GetMouseButtonDown(0))
        {
            VerificaProximaFase();
        }

        if(acabouTempo && Input.GetMouseButtonDown(0))
        {
            ReiniciaJogo();
        }

        VerificaTempo();

        VerificaCliqueAchou();
    }

    void ReiniciaJogo()
    {
        verificaAchou = false;
        textoTempo.SetActive(false);
        sansao.ResetClick();
        timerCenario.StopTime();
        timerCenario.RestartTime();
        acabouTempo = false;
        SceneManager.LoadScene("CenarioMenu");
        
    }

    void VerificaCliqueAchou()
    {
        if(sansao.cliquei==true && timerCenario.timeRemaining > 0){
            textoAchei.SetActive(true);
            timerCenario.StopTime();
            verificaAchou = true;
            Debug.Log("Achou Sansão:"+verificaAchou);
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
            SceneManager.LoadScene("CenarioMenu");
        }
    }

    void VerificaTempo()
    {
        if(timerCenario.timeRemaining == 0)
        {
            textoTempo.SetActive(true);
            acabouTempo = true;
        }
    }
}
