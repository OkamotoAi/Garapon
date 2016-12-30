using UnityEngine;
using System.Collections;

/*
 * ガラポンの回転を止めたり回したりするためのボタン用スクリプト
 */ 
public class RotateButton : MonoBehaviour {

    // ボタンをクリックした時の処理
    public void OnClick()
    {
        GetComponent<Rotater>().enabled = !GetComponent<Rotater>().enabled;
    }
}
