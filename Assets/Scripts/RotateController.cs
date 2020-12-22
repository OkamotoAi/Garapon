using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    // ガラポンのオブジェクト
    private GameObject garapon;
    // 回転／停止ボタンのオブジェクト
    private GameObject rotateControlButton;
    // ガラポンの回転／停止状態
    private bool isRotate = false;

    // ガラポンの回転スピード
    public float speed = 1.0f;

    private void Start()
    {
        garapon = GameObject.Find("Garapon");
        rotateControlButton= GameObject.Find("RotateControlButton");
    }
    private void Update()
    {
        garapon.transform.Rotate(0.0f, 0.0f, isRotate ? -0.2f * speed : 0.0f);
    }

    public void SwitchRotateState()
    {
        isRotate = !isRotate;
        rotateControlButton.GetComponentInChildren<UnityEngine.UI.Text>().text = isRotate ? "とめる" : "まわす";
    }
}
