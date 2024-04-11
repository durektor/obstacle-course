using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // SerializeField adds the value to the inspector in Unity
    // [SerializeField] float xValue = 0f;
    // [SerializeField] float yValue = 0f;
    // [SerializeField] float zValue = 0f;
   
    // Start is called before the first frame update

    [SerializeField] float moveSpeed = 10f;

    

    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the 3D object Oscar .01 per frame along the x-axis
        // the f tells the compiler that the number is a float
        // transform.Translate(0.01f,0,0);

        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
