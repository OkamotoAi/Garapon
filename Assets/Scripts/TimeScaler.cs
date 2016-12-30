using UnityEngine;
using System.Collections;

/* 
 * 時間の流れを早くすることができるスクリプト。
 * 当時、デバッグに役立つだろうと思い作成した。
 * しかし、物理演算に影響を与えるため、正確に動作しなくなる。
 */
public class TimeScaler : MonoBehaviour {

    // タイムスケール
    public float timeScale = 1.0F;

	void Start () {
	
	}
	
	void Update () {
        Time.timeScale = this.timeScale;
	}
}
