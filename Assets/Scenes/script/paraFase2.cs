using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class paraFase2 : MonoBehaviour
{
    public int life = 3;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
    
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
                    
        if(collision.gameObject.CompareTag("passaFase2"))
        {
            SceneManager.LoadScene("Fase2", LoadSceneMode.Additive);
            
        }
        
    }
}
