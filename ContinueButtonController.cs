﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButtonController : MonoBehaviour {


    public void OnClick() {
        Debug.Log("hoge!");
        SceneManager.LoadScene("GameScene");
    }
}
