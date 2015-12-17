using UnityEngine;
using System.Collections;

public class ButtonRotator : MonoBehaviour {

    /// ボタンをクリックした時の処理
    public void OnClick()
    {
        GetComponent<Rotater>().enabled = !GetComponent<Rotater>().enabled;
    }
}
