using UnityEngine;
using System.Collections;

/*
 * オブジェクトを回転させるだけのスクリプト。
 * ガラポンに限らず、アタッチすればなんでも回る。
 */ 
public class Rotater : MonoBehaviour {

    // 回転するスピード
    public float speed = 1.0F;

	void Start ()
    {
    }

	void Update ()
    {
        transform.Rotate(new Vector3(0.0F, 0.5F * speed, 0.0F));
	}
}
