using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    
    private Tela_inicial telaInicial;

    // Start is called before the first frame update
    void Start()
    {
        this.telaInicial = GameObject.FindObjectOfType<Tela_inicial>();
    }

    public void ReiniciaJogo()
    {
        telaInicial.MostraTelaInicial();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            telaInicial.EscondeTelaInicial();
            Debug.Log("esconde");
        }
    }
}
