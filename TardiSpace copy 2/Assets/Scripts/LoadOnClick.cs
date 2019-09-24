﻿using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

    public void LoadScene(int level) //loadscene takes a parameter of the type int. index of the level of the build setting
    {
        Application.LoadLevel(level); //loads scenes in unity. parameter 'level' is the index in the build settings of the level we want loaded
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            Application.LoadLevel(0);
        }
        
        if(Input.GetKeyDown(KeyCode.I))
        {
            Application.LoadLevel(2);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Application.LoadLevel(1);
        }
    }

}
