using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tela_inicial : MonoBehaviour
{
    
    public GameObject telaInicial;

    public void MostraTelaInicial()
    {
        this.telaInicial.SetActive(true);
    }

    public void EscondeTelaInicial()
    {
        this.telaInicial.SetActive(false);
    }
}
