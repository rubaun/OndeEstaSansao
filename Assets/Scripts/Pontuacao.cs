using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    
    private float tempoInicial;
    private float tempoRestante;
    private bool tempoCorrendo;
    private bool contagemFeita;
    public Text textoPontos;
    private Pontos pontos;

    
    // Start is called before the first frame update
    void Start()
    {
        pontos = GameObject.FindObjectOfType<Pontos>();
        contagemFeita = false;
        textoPontos.text = pontos.pontosAcumulados.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DefineTempoInicial(float tempoInicio)
    {
        tempoInicial = tempoInicio;
    }

    public void DefineTempoRestante(float tempoResta)
    {
        tempoRestante = tempoResta;
    }

    public void DefineTempoCorrendo(bool tempocorre)
    {
        tempoCorrendo = tempocorre;
    }

    public void PontuacaoDaFase(float tempoResta)
    {
        if(!contagemFeita)
        {
            pontos.CalculaPontos(tempoResta);
            pontos.SomaPontos();
            pontos.EncerraContagem();
            if(textoPontos != null)
                {
                    textoPontos.text = pontos.pontosAcumulados.ToString();
                }
        }

    }

    public void ZeraPontos()
    {
        pontos.SendMessage("Destruir");
        Debug.Log("Enviando Mensagem para Pontos");
    }

    public void SetContagem(bool contado)
    {
        contagemFeita = contado;
    }
}
