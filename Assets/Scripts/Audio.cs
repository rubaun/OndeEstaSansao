using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
    public string cenaAtual;
    //private AudioSource audio;
    private Timer timerCenario;

    /*private void Awake() {
        DontDestroyOnLoad(this);
    }*/
    
    // Start is called before the first frame update
    void Start()
    {
        cenaAtual = SceneManager.GetActiveScene().name;
        this.timerCenario = GameObject.FindObjectOfType<Timer>();
        //audio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        cenaAtual = SceneManager.GetActiveScene().name;
        
        if(cenaAtual == "CenarioFinal")
        {
            DestroyImmediate(this.gameObject);
        }

        
    }

    public void Destruir()
    {
        DestroyImmediate(this.gameObject);
    }
}
