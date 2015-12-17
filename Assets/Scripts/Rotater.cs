using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {

    public int speed = 1;

	// Use this for initialization
	void Start ()
    {
    }

	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(new Vector3(0.0F, 0.5F * speed, 0.0F));
	}
}
