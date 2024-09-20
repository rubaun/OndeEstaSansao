using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAchou : MonoBehaviour
{

    private AudioSource playSomAchou;
    public AudioClip somAchou;

    // Start is called before the first frame update
    void Start()
    {
        playSomAchou = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySomAchou()
    {
        playSomAchou.PlayOneShot(somAchou);
    }

}
