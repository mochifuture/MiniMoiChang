using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    private Camera mainCamera;
    public GameObject playerObject;
    public float rotateSpeed = 2.0f;
    private float y = 5;
    float speed = 0.5f;

    void Start() {
        mainCamera = GetComponent<Camera>();
        playerObject = GameObject.Find("minimoi");
    }

    void Update() {
        ZoomInCamera(speed);

        //メインカメラを回転させる
        mainCamera.transform.RotateAround(playerObject.transform.position, Vector3.up, rotateSpeed);
    }

    // カメラをズームイン
    private void ZoomInCamera(float speed) {
        float view = mainCamera.fieldOfView - speed;
        mainCamera.fieldOfView = Mathf.Clamp(value: view, min: 10.0f, max: 45f);
    }

}