using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CenarioMenu : MonoBehaviour
{
    
    private Pontos pontosParaDeletar;
    

    // Start is called before the first frame update
    void Start()
    {
        pontosParaDeletar = GameObject.FindObjectOfType<Pontos>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Cenario1");
        }

        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }

        if(pontosParaDeletar != null){
            DestroyImmediate(pontosParaDeletar.gameObject);
        }
    }
}
