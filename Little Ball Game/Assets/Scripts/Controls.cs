using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public float ballSpeed;
    public Rigidbody2D oRigidbody2D;
    private Vector2 keyboardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BallMoviment();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }

    }

    private void BallMoviment()
    {
        keyboardInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        oRigidbody2D.linearVelocity = keyboardInput.normalized * ballSpeed;
    }

    private void QuitGame()
    {
        Application.Quit();
    }
}
