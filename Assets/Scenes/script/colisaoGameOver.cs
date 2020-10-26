using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colisaoGameOver : MonoBehaviour
{
    public int life= 3;
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
        if(collision.gameObject.CompareTag("caiuMorreu"))
        {
            SceneManager.LoadScene("GamerOver", LoadSceneMode.Additive);            
        }
        if(collision.gameObject.CompareTag("enemy"))
        {
            if(life <=0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("GamerOver", LoadSceneMode.Additive);
            }else{
                life = life - 1 ;
            }
            
        }
        
    }
}
