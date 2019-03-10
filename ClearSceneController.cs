using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearSceneController : MonoBehaviour {

    MoichangController moichangController;
    public GameObject appleCounter;

    private int score = 0;

    void Start() {
        this.moichangController = GameObject.Find("minimoi").GetComponent<MoichangController>();
        this.appleCounter = GameObject.Find("AppleCounter");
        this.SetCounterValues();
    }

    void Update() {
    }

    void SetCounterValues() {
        this.score = moichangController.GetAppleCount();
        this.appleCounter.GetComponent<Text>().text = this.score.ToString();
    }
}
