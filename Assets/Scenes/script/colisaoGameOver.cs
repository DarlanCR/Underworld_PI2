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

    private void OnColliderEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("caiuMorreu"))
        {
            if(life <=0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(0);
            }else{
                life = life - 1 ;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
                        
        }
        if(other.gameObject.CompareTag("enemy"))
        {
            if(life <=0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(0);
                
            }else{
                life = life - 1 ;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            
        }
        
    }
}
