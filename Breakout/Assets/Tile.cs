using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

    public BoxCollider collider;
    public GameObject me;

    void OnTriggerEnter(Collider _other)
    {
        Debug.Log("Trigger");
        _other.gameObject.GetComponent<Movement>().yVelocity = _other.gameObject.GetComponent<Movement>().yVelocity * -1;
        me.SetActive(false);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
