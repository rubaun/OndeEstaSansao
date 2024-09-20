using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void IniciaJogo()
    {
        SceneManager.LoadScene("Cenario1");
    }
}
