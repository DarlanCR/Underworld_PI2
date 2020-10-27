using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public Transform DetectaChao;
    public float distancia = 3;
    public bool olhandoParaDireita;
    public float velocidade = 1;

    void Start()
    {

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
            if (!olhandoParaDireita)
            {
                
                transform.eulerAngles = new Vector3(0, -180, 0);
                olhandoParaDireita = true;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                olhandoParaDireita = false;
            }
        }
        
         
    }

    /*void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.CompareTag("Player")){
            other.gameObject.GetComponent<PlayerLife>().PerdeVida();
        }
    }*/
}