using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sansao : MonoBehaviour
{
    public bool cliquei;
    [SerializeField] private GameObject txtAchei;
    [SerializeField] private string nome;
    [SerializeField] private string sansaoClicado;
    [SerializeField] private int randPos;
    [SerializeField] private List<Vector3> pos = new List<Vector3>();
    private float xPos = 0;
    private float yPos = 0;
    private float zPos = 0;    

    // Start is called before the first frame update
    void Start()
    {
        randPos = Random.Range(0, pos.Count);
        xPos = pos[randPos].x;
        yPos = pos[randPos].y;
        zPos = pos[randPos].z;
        transform.position = new Vector3(xPos, yPos, zPos);
        cliquei = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if(hit.collider != null)
            {
                sansaoClicado = hit.collider.name;
                SetClick();
            }
                  
        }

    }

    public void SetClick()
    {
        cliquei = true;
    }

    public void ResetClick()
    {
        cliquei = false;
    }

}