using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour
{
    
    public float pontosAcumulados;
    public float pontosCalculados;
    
    private void Awake() 
    {
        DontDestroyOnLoad(this);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        pontosAcumulados = 0;
    }

    // Update is called once per frame
    void Update()
    {
                
    }

    public void SomaPontos()
    {
        pontosAcumulados += pontosCalculados;
    }

    public void CalculaPontos(float tempoRestante)
    {
        pontosCalculados = 100 * Mathf.FloorToInt(tempoRestante);
    }

    public void EncerraContagem()
    {
        pontosCalculados = 0;
    }

    public void Destruir()
    {
        DestroyImmediate(this.gameObject);
    }
}
