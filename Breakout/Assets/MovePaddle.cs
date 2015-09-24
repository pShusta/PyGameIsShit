using UnityEngine;
using System.Collections;

public class MovePaddle : MonoBehaviour
{
    public float paddleSpeed = 1f;


    private Vector3 position = new Vector3(0, -7, 0);


    void Update()
    {

        float X_position = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        position = new Vector3(Mathf.Clamp(X_position, -7.3f, 7.3f), -7f, 0f);
        transform.position = position;

    }
}
