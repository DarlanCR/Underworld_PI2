﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PerdeVida(){
        GameManager.gm.SetVidas(-1);
    }

    public void Reset(){
        if(GameManager.gm.GetVidas()>= 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}