using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearSceneController : MonoBehaviour {

    MoichangController moichangController;
    AppleGenerator appleGenerator;
    public GameObject appleCounter;

    private int score = 0;
    private AudioSource soundRingoUmaina;
    private bool once = true;

    void Start() {
        this.moichangController = GameObject.Find("minimoi").GetComponent<MoichangController>();
        this.appleGenerator = GameObject.Find("AppleGenerator").GetComponent<AppleGenerator>();
        this.appleCounter = GameObject.Find("AppleCounter");
        this.SetCounterValues();
        AudioSource[] audioSources = GetComponents<AudioSource>();
        this.soundRingoUmaina = audioSources[0];    
    }

    void Update() {
        if(once) {
            soundRingoUmaina.PlayOneShot(soundRingoUmaina.clip);
            once = false;
        }
        const float span = 0.1f;
        this.appleGenerator.setSpan(span);
    }

    void SetCounterValues() {
        this.score = moichangController.GetAppleCount();
        this.appleCounter.GetComponent<Text>().text = this.score.ToString();
    }
}
