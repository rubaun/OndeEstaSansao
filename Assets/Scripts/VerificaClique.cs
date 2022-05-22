using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificaClique : MonoBehaviour
{
    public bool verificaClique;

    // Start is called before the first frame update
    void Start()
    {
        verificaClique = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if(hit.collider != null)
            {
                //Debug.Log(hit.collider.name);
                verificaClique = true;
            }
                  
        }
    }
}
