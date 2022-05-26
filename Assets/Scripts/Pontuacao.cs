using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    
    public int pontos;
    private Timer timer;
    private float tempoInicial;
    public Text textoPontos;

    private void Awake() 
    {
        DontDestroyOnLoad(this);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.FindObjectOfType<Timer>();
        pontos = 0;
        tempoInicial = timer.timeInitial;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(!timer.timeIsRunning)
        {
            CalculaPontos();
            SomaPontos(pontos);
            if(textoPontos != null)
            {
                textoPontos.text = pontos.ToString();
            }
        }

        /* if(!timer.timeIsRunning && timer.timeRemaining == 0)
        {
            pontos = 0;
        } */

        
    }

    public void SomaPontos(int pontosNovos)
    {
        pontos += pontosNovos;
    }

    public void CalculaPontos()
    {
        pontos = 100 * Mathf.FloorToInt(timer.timeRemaining);
    }
}
