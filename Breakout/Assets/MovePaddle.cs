using UnityEngine;
using System.Collections;

public class MovePaddle : MonoBehaviour
{
    public float paddleSpeed = 1f;


    private Vector3 position = new Vector3(0, -7, 0);


    void Update()
    {

        float X_position = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        float Z_position = transform.position.z + (Input.GetAxis("Vertical") * paddleSpeed);
        position = new Vector3(Mathf.Clamp(X_position, 1.4f, 11f), .68f, Mathf.Clamp(Z_position, -6.6f, 0f));
        transform.position = position;
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void OnTriggerEnter(Collider _other)
    {
        _other.gameObject.GetComponent<Movement>().curY = _other.gameObject.GetComponent<Movement>().curY * -1;
        this.gameObject.GetComponent<AudioSource>().Play();
    }
}
