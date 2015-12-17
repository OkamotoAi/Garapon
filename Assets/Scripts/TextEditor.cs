using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections.Generic;



public class TextEditor : MonoBehaviour {

    public GameObject text;
    public GameObject newDead;

    private int ballNum = 0;
    private const uint Max = 72;
    private static bool[] isThrough = new bool[Max];
    private static int[] passed;
    private static List<int> deadNum;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < isThrough.Length; i++)
        {
            isThrough[i] = false;
        }
        deadNum = new List<int>();
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
            isThrough[num - 1] = true;
            deadNum.Add(num);
            deadNum.Sort();
            ballNum++;
            string str;
            str = string.Join(" ", deadNum.Select(x => x.ToString()).ToArray());
            text.GetComponent<Text>().text = str;
            newDead.GetComponent<Text>().text = num.ToString();
        }

    }
}
