using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Audio : MonoBehaviour
{
    public string cenaAtual;
    private AudioSource audioP;
    private Timer timerCenario;
    public List<AudioClip> sons;

    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(this);
        audioP = GetComponent<AudioSource>();
        cenaAtual = SceneManager.GetActiveScene().name;
        //this.timerCenario = GameObject.FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        cenaAtual = SceneManager.GetActiveScene().name;
        
        if(cenaAtual == "CenarioMenu")
        {
            audioP.PlayOneShot(sons[0], 0.5f);
        }
        else if(cenaAtual == "Cenario1")
        {
            audioP.PlayOneShot(sons[1], 0.5f);
        }
        
    }

}
