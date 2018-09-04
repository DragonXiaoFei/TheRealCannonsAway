using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    [SerializeField] float screenWidth = 16f;
    [SerializeField] float minX = 1.43f;
    [SerializeField] float maxX = 14.6f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float mousePos = Input.mousePosition.x / Screen.width * screenWidth;
        mousePos = Mathf.Clamp(mousePos, minX, maxX);
        Vector2 paddlePos = new Vector2(mousePos, transform.position.y);
        transform.position = paddlePos;
	}
}
