using UnityEngine;
using System.Collections;

public class BallGen : MonoBehaviour
{

    public GameObject ball;
    public float time;

    private int ballNum = 1;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine("makeBall");
	}

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
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
