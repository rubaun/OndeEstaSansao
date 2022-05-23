using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    
    private Tela_inicial telaInicial;
    private Timer timerCenario;
    private Sansao sansao;
    private int cenarioAtual;
    private bool verificaAchou;
    private bool acabouTempo;
    public GameObject textoAchei;
    public GameObject textoTempo;
    public GameObject cenario1;
    public GameObject cenario2;
    public GameObject cenario3;



    // Start is called before the first frame update
    void Start()
    {
        cenarioAtual = 1;
        verificaAchou = false;
        acabouTempo = false;
        cenario1.SetActive(true);
        cenario2.SetActive(false);
        cenario3.SetActive(false);
        this.telaInicial = GameObject.FindObjectOfType<Tela_inicial>();
        this.timerCenario = GameObject.FindObjectOfType<Timer>();
        this.sansao = GameObject.FindObjectOfType<Sansao>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            telaInicial.EscondeTelaInicial();
            timerCenario.StartTime();
            //Debug.Log("esconde");
        }

        if(verificaAchou && Input.GetMouseButtonDown(0))
        {
            VerificaProximaFase(cenarioAtual);
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
        cenarioAtual = 1;
        cenario1.SetActive(true);
        cenario2.SetActive(false);
        cenario3.SetActive(false);
        textoTempo.SetActive(false);
        sansao.ResetClick();
        timerCenario.StopTime();
        timerCenario.RestartTime();
        telaInicial.MostraTelaInicial();
        acabouTempo = false;
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

    void VerificaProximaFase(int cenarioAtual)
    {
        if(verificaAchou)
        {
            if(cenarioAtual == 1)
            {
                verificaAchou = false;
                cenario1.SetActive(false);
                cenario2.SetActive(true);
                textoAchei.SetActive(false);
                timerCenario.RestartTime();
                timerCenario.StartTime();
                sansao.ResetClick();
                cenarioAtual = 2;
            }
            else if(cenarioAtual == 2)
            {
                cenario2.SetActive(false);
                cenario3.SetActive(true);
                textoAchei.SetActive(false);
                timerCenario.RestartTime();
                timerCenario.StartTime();
                sansao.ResetClick();
                cenarioAtual = 3;
            }
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
