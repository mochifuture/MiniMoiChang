using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoichangController : MonoBehaviour {

    Animator animator;

    void Start() {
        this.animator = GetComponent<Animator>();
    }


    void Update() {
        if (Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.J)) {
            this.animator.SetTrigger("JumpTrigger");
        }

        // 上下左右移動
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(0, 0, 0.5f);
        }

        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical")) {
            transform.rotation = Quaternion.LookRotation(transform.position +
            (Vector3.right * Input.GetAxisRaw("Horizontal")) +
            (Vector3.forward * Input.GetAxisRaw("Vertical"))
            - transform.position);
        }

        // 正面を向く
        if (Input.GetButtonUp("Horizontal") || Input.GetButtonUp("Vertical")){
            transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
        }

    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("衝突！");
        Destroy(other.gameObject);
    }
}
