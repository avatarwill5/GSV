﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class beginWorldGen : MonoBehaviour {

    private Button _btn;

    // Use this for initialization
    void Start()
    {
        _btn = this.GetComponent<Button>();
        _btn.onClick.AddListener(commenceWorldGen);

    }

    void commenceWorldGen()
    {
        //Replace this with the async version and a nice loading screen
        //I'm talking to you
        //Do it
        //Do it now
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
