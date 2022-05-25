using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontuacao : MonoBehaviour
{
    
    public int pontos;
    public string cenarioNumero;
    // Start is called before the first frame update
    void Start()
    {
        pontos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SomaPontos(int pontosNovos)
    {
        pontos += pontosNovos;
    }
}
