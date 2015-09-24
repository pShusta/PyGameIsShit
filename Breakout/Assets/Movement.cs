using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public int yVelocity, xVelocity;
    public Transform trans;

	// Use this for initialization
	void Start () {
        yVelocity = 3;
        xVelocity = 3;
	}
	
	// Update is called once per frame
	void Update () {
        trans.position = Vector3.Lerp(trans.position, new Vector3(trans.position.x + xVelocity, trans.position.y + yVelocity, trans.position.z), Time.deltaTime);
	}
}
