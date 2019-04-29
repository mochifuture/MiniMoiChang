using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleGenerator : MonoBehaviour {

    public GameObject applePrefab;
    float span = 0.3f;
    float delta = 0;
    public bool generateApple = true;

    void Start () {
    }
	
	void Update () {

        if (this.generateApple == true) {
            this.delta += Time.deltaTime;
            if (this.delta > this.span) {
                this.delta = 0;
                GameObject apple = Instantiate(applePrefab) as GameObject;
                float x = Random.Range(-20, 20);
                float z = Random.Range(-5, 30);
                apple.transform.position = new Vector3(x, 18, z);
            }
        }
    }

    public void stopGenerateApple() {
        this.generateApple = false;
    }

    public void setSpan (float span) {
        this.span = span;
    }
}
