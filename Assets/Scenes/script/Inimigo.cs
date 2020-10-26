using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public Transform DetectaChao;
    public Transform DetectaParede; 
    public float distancia = 3;
    public int olhandoParaDireita = 1;
    public float velocidade = 1;

    void Start()
    {
        olhandoParaDireita = 1;
    }

    void Update()
    {
        Patrulha();
    }

    public void Patrulha()
    {
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(DetectaChao.position, Vector2.down, distancia);
        if (groundInfo.collider == false)
        {
            if (olhandoParaDireita != 0)
            {
                
                transform.eulerAngles = new Vector3(0, -180, 0);
                olhandoParaDireita = 0;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                olhandoParaDireita = 1;
            }
        }
        RaycastHit2D groundParede = Physics2D.Raycast(DetectaParede.position, Vector2.down, distancia);
        if (groundParede.collider == false)
        {
            if (olhandoParaDireita != 1)
            {
                
                transform.eulerAngles = new Vector3(0, -180, 0);
                olhandoParaDireita = 1;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                olhandoParaDireita = 0;
            }
        }
         
    }  
}