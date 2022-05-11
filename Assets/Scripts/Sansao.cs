using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sansao : MonoBehaviour
{
    public bool cliquei;
    public GameObject txtAchei;
    private Vector3 posicao;

    // Start is called before the first frame update
    void Start()
    {
        cliquei = false;
        posicao = transform.position;
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
                Debug.Log(hit.collider.name);
                cliquei = true;
            }
                  
            //if(transform.position
            //    cliquei = true;
        }

        if(cliquei==true){
            txtAchei.SetActive(true); 
        }
    }
}
