using UnityEngine;
using System.Collections;

/*
 * ボールの生成スクリプト。
 * 生成のための空のオブジェクトに貼ってください。
 * 生成し終わったら、生成用のオブジェクトを消すようにできています。
 */ 
public class BallGenerater : MonoBehaviour
{
    // ボールのオブジェクト
    public GameObject ball;
    // ボールを生成する間隔
    public float time;

    private int ballNum = 1;

	void Start ()
    {
        StartCoroutine("makeBall");
	}

    // ボールを生成するコルーチン
    IEnumerator makeBall()
    {
        for (int i = 1; i <= 72; i++)
        {
            GameObject newBall = Instantiate(ball);

            newBall.GetComponent<MeshRenderer>().material.mainTexture = Resources.Load<Texture2D>("Number/" + ballNum);
            newBall.name = "" + ballNum;
            ballNum++;
            
            Debug.Log(newBall.name + "生成");

            yield return new WaitForSeconds(time);
        }
        Destroy(this.gameObject);
    }
	
	void Update ()
    {
	}
}
