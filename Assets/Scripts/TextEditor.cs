using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextEditor : MonoBehaviour {

    public GameObject text;

    private int ballNum = 0;
    private static bool[] isThrough = new bool[72];

	// Use this for initialization
	void Start () {
        for (int i = 0; i < isThrough.Length; i++)
        {
            isThrough[i] = false;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        int num = int.Parse(col.gameObject.name);

        Debug.Log(num + "通過");
        if (!isThrough[num - 1])
        {
            text.GetComponent<Text>().text += num + " ";
            ballNum++;
            isThrough[num - 1] = true;
        }
    }
}
