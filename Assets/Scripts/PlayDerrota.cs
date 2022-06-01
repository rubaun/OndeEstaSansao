using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDerrota : MonoBehaviour
{
    
    private AudioSource playSomDerrota;

    // Start is called before the first frame update
    void Start()
    {
        playSomDerrota = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySomDerrota()
    {
        playSomDerrota.Play();
    }
}
