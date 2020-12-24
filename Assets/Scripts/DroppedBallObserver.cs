using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppedBallObserver : MonoBehaviour
{
    public GameObject droppedBallImage;

    // Start is called before the first frame update
    void Start()
    {
        GameObject canvas = GameObject.Find("Canvas");

        for (int i = 0; i < 72; i++)
        {
            GameObject newBallImage = Instantiate(droppedBallImage);
            String spriteFileName = String.Format("UI/ball-gray-{0:00}-bingo", i+1);

            //Vector2 offset = new Vector2(((int)i % 15) * 60.0f, ((int)i / 15) * 60.0f);
            //newBallImage.GetComponent<RectTransform>().position = newBallImage.GetComponent<RectTransform>().anchoredPosition + offset;
            newBallImage.name = String.Format("BallImage{0:00}", i+1);
            newBallImage.GetComponent<RectTransform>().position = new Vector2(((int)i % 6) * 50.0f + 1400.0f, -((int)i / 6) * 50.0f + 750.0f);
            newBallImage.GetComponent<UnityEngine.UI.Image>().sprite = Resources.Load<Sprite>(spriteFileName);
            newBallImage.transform.parent = canvas.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
